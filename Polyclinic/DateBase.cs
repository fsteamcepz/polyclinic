using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    internal class DateBase
    {
        // Символ @ - означає все, що в лапках форматуванню не підлягає, тобто використовувати як є
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=TEMA;Initial Catalog=Polyclinic;Integrated Security=True");

        // відкрити зв'язок з БД
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        // закрити зв'язок з БД
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // метод getConnection повертає рядок
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
