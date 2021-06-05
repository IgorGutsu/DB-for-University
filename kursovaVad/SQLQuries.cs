using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD = System.Data;
using System.Windows.Forms;

namespace kursovaVad
{
    class SQLQuries : SQLConnections
    {
        public override void Query(string script, DataGridView dg1)
        {
            if (connectionTrue)
            {
                MySqlDataAdapter ms_data = new MySqlDataAdapter("SELECT * from  " + script, connect);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                dg1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Підключіться до БД!");
            }
        }
        public void QueryFind(string tabl, string cell, string like, DataGridView dg1)
        {
            try
            {
                MySqlDataAdapter ms_data = new MySqlDataAdapter("SELECT * FROM " + tabl + " WHERE " + cell + " Like '" + like + "'", connect);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                dg1.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Перевірте вірність даних");
            }
            
        }
        public void QueryNow(string script, DataGridView dg1)
        {
            if (connectionTrue)
            {
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                dg1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Підключіться до БД!");
            }
        }
    }
}
