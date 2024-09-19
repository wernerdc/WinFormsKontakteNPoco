using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsKontakteNPoco
{
    internal class Contact
    {
        public Contact(string forename, string name, string phone, string email)
        {
            Forename = forename ?? String.Empty;
            Name = name ?? String.Empty;
            Phone = phone ?? String.Empty;
            Email = email ?? String.Empty;
            ChangedAt = DateTime.Now;
            CreatedAt = DateTime.Now;
        }

        public Contact(int id, string forename, string name, string phone, string email, DateTime changedAt, DateTime createdAt)
        {
            Id = id;
            Forename = forename ?? String.Empty;
            Name = name ?? String.Empty;
            Phone = phone ?? String.Empty;
            Email = email ?? String.Empty;
            ChangedAt = changedAt;
            CreatedAt = createdAt;
        }

        public int Id {  get; set; }
        public string Forename { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime ChangedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
