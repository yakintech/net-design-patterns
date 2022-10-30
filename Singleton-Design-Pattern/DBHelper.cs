using System;

namespace SingletonDesignPattern
{
    public class DBHelper
    {
        private DBHelper(string connectionstring)
        {

        }

        private static DBHelper _helper;

        public static DBHelper CreateDbHelper(string connectionstring)
        {
            if (_helper == null)
            {
                _helper = new DBHelper(connectionstring);
            }

            return _helper;
        }
        public string ConnectionString { get; set; }

        public string StateMessage { get; set; }
    }
}

