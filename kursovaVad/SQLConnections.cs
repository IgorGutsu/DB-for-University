using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SD = System.Data;

namespace kursovaVad
{
    class SQLConnections
    {
        public MySqlConnection myconn;
        public MySqlCommand command;
        public string connect = "Server=localhost;Database=bd_disc;Uid=root;pwd=federico2001;charset=utf8";
        public SD.DataSet ds;
        public static bool connectionTrue = false;

        public virtual void Query(string tabl, DataGridView dg1)
        {
            try
            {
                myconn = new MySqlConnection(connect);
                myconn.Open();
                MessageBox.Show("Підключення успішне");
                myconn.Close();
                dg1.DataSource = tabl;
                connectionTrue = true;
            }
            catch
            {
                MessageBox.Show("Помилка підключення");
            }
        }
        public void QueryDrop()
        {
            myconn.Close();
            MessageBox.Show("БД Відключено");
            Application.Exit();
        }
    }
}
