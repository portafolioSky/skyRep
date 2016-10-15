using System;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows;

namespace MantenedoresCRUD.dataBase
{
    class Data
    {
        private string user;
        private string pass;
        private static Data miBase;
        private OracleConnection cnn;
        private string stringCnn;
        //private OracleCommand cmd;


        private Data()
        {
            user = "sescuela";
            pass = "asder";
            stringCnn = string.Format(@"DATA SOURCE=localhost:1521/XE;USER ID={0}; PASSWORD={1};", user, pass);
            cnn = new OracleConnection(stringCnn);
        }

        public void Close()
        {
            Cnn.Close();
            try
            {
                Cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool Open()
        {

                Cnn.Open();
                return true;      
        }

        public OracleConnection Cnn
        {
            get
            {
                return cnn;
            }

            set
            {
                cnn = value;
            }
        }

       
        public static Data getInstance()
        {
            if (miBase == null)
                miBase = new Data();
            return miBase;
        }


        public String getUsuario()
        {
            return user + ".";
        }

    }
}
