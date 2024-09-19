using MySqlConnector;
using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace WinFormsKontakteNPoco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitDataGridView();
        }
        string ConnectionString { get; init; } = ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;

        private List<Contact> LoadContacts()
        {
            List<Contact> list = new();
            try
            {
                using MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(mySqlConnection);
                mySqlConnection.Open();
                string sql = "order by name, forename";
                list = db.Fetch<Contact>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return list;
        }

        private void InitDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            //dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ShowContacts(List<Contact> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Contact> list = LoadContacts();
            ShowContacts(list);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Contact? contact = dataGridView1.CurrentRow.DataBoundItem as Contact;
            if (contact == null)
                return;
            ShowContactInInput(contact);
        }

        private void ShowContactInInput(Contact contact)
        {
            textBoxId.Text = contact.Id.ToString();
            textBoxForename.Text = contact.Forename;
            textBoxName.Text = contact.Name;
            textBoxPhone.Text = contact.Phone;
            textBoxEmail.Text = contact.Email;
        }

        private void AddContact(Contact contact)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Insert(contact);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void editContact(Contact contact)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Update(contact);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void DeleteContact(Contact contact)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Delete(contact);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact(textBoxForename.Text, textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text);
            AddContact(contact);
            List<Contact> lst = LoadContacts();
            ShowContacts(lst);
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            Contact? contact = dataGridView1.CurrentRow.DataBoundItem as Contact;
            if (contact == null)
                return;

            Contact editedContact = new Contact(
                    contact.Id,
                    textBoxForename.Text,
                    textBoxName.Text,
                    textBoxPhone.Text,
                    textBoxEmail.Text,
                    DateTime.Now,
                    contact.CreatedAt);

            editContact(editedContact);
            List<Contact> lst = LoadContacts();
            ShowContacts(lst);
        }

        private void buttonDelContact_Click(object sender, EventArgs e)
        {
            Contact? contact = dataGridView1.CurrentRow.DataBoundItem as Contact;
            if (contact == null)
                return;

            DeleteContact(contact);
            List<Contact> lst = LoadContacts();
            ShowContacts(lst);
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
