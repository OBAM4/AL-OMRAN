using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace testOmrane
{
    class Conee
    {

        public SqlConnection cnx = new SqlConnection();
        public SqlCommand query = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        // Methodee connecter
        public void connecter()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.ConnectionString = @"Data Source=DESKTOP-7RGNTFV\SQLEXPRESS01;Initial Catalog=AlOmran;Integrated Security=True";
                cnx.Open();
            }
        }
        // Methode deconnecter
        public void deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}
