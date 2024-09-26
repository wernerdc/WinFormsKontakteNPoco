using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessContact
{
    public interface IDbAccess
    {
        public bool CheckDatabaseExistence();
        public bool CreateDatabase();
        public List<Contact> GetAll();
        public Contact GetOne(int id);
        public void AddOne(Contact element);
        public void UpdateOne(Contact element);
        public void DeleteOne(Contact element);
        //public List<Contact> SearchOne(string search);


        //public static abstract bool CheckDatabaseExistence();
        //public static abstract bool CreateDatabase();
        //public static abstract List<Contact> GetAll();
        //public static abstract Contact GetOne(int id);
        //public static abstract void AddOne(Contact element);
        //public static abstract void UpdateOne(Contact element);
        //public static abstract void DeleteOne(Contact element);
    }
}
