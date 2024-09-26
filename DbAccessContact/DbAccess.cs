using MySqlConnector;
using NPoco;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Linq;

namespace DbAccessContact
{
    public class DbAccess : IDbAccess
    {
        // admin account
        private static string ConnectionStringAdmin { get; }
                = ConfigurationManager.ConnectionStrings["mariadb_admin"].ConnectionString;
        // should be ordinary user account (here both are admin)
        private static string ConnectionString { get; }
                = ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;

        public bool CheckDatabaseExistence()
        {
            int count = 0;
            try
            {
                // separate ConnectionString to access database as admin: information_schema
                using MySqlConnection connection = new MySqlConnection(ConnectionStringAdmin);
                connection.Open();

                string sql = "SELECT COUNT(SCHEMA_NAME) FROM information_schema.SCHEMATA WHERE SCHEMA_NAME = @dbName";
                using MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add("@dbName", MySqlDbType.VarChar).Value = "contacts";

                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
            Debug.WriteLine($"DBHelper - Database found: {count}");
            return (count > 0);
        }

        public bool CreateDatabase()
        {
            int count = -1;
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionStringAdmin);
                connection.Open();
                // # Datenbank erstellen
                string sqlCreateDB = "CREATE DATABASE IF NOT EXISTS contacts";
                // # Tabelle für Kontakte erstellen
                string sqlCreateTable = "CREATE TABLE contact(" +
                        "id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                        "forename VARCHAR(50), " +
                        "name VARCHAR(50)," +
                        "phone VARCHAR(30)," +
                        "email VARCHAR(100)," +
                        "changedAt DATETIME," +
                        "createdAt DATETIME)";

                using MySqlCommand cmdCreateDb = new MySqlCommand(sqlCreateDB, connection);
                cmdCreateDb.ExecuteNonQuery();

                // switch to use newly created database
                connection.ChangeDatabase("contacts");
                using MySqlCommand cmdCreateTable = new MySqlCommand(sqlCreateTable, connection);
                count = cmdCreateTable.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }

            Debug.WriteLine($"DBHelper - Tables created: {count + 1}");
            return (count >= 0);
        }

        public List<Contact> GetAll()
        {
            List<Contact> list = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                string sql = "ORDER BY name";
                list = db.Fetch<Contact>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return list;
        }

        public Contact GetOne(int id)
        {
            Contact? element = null;
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                element = db.SingleById<Contact>(id);
                //string sql = "WHERE id = @0";
                //element = db.Single<Contact>("WHERE id = @0", id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return element ?? new Contact();      // ?? -> check if element is null
        }

        public void AddOne(Contact element)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                db.Insert(element);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void UpdateOne(Contact element)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                db.Update(element);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void DeleteOne(Contact element)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using Database db = new Database(connection);
                connection.Open();
                db.Delete(element);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
