using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD=System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kursovaVad
{
    
    public partial class Form1 : Form
    {
        SQLConnections sq1 = new SQLConnections();
        SQLQuries CQuery = new SQLQuries();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    CQuery.Query("students", dataGridView1);
                    break;
                case 1:
                    CQuery.Query("teachers", dataGridView2);
                    break;
                case 2:
                    CQuery.Query("materials", dataGridView3);
                    break;
                case 3:
                    CQuery.Query("questions", dataGridView4);
                    break;
                case 4:
                    CQuery.Query("termins", dataGridView5);
                    break;
                case 5:
                    CQuery.Query("tests", dataGridView6);
                    break;
                case 6:
                    CQuery.Query("test_results", dataGridView7);
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = 0;
                    break;
                case 1:
                    dataGridView2.DataSource = 0;
                    break;
                case 2:
                    dataGridView3.DataSource = 0;
                    break;
                case 3:
                    dataGridView4.DataSource = 0;
                    break;
                case 4:
                    dataGridView5.DataSource = 0;
                    break;
                case 5:
                    dataGridView6.DataSource = 0;
                    break;
                case 6:
                    dataGridView7.DataSource = 0;
                    break;
            }
        }
        private void add_bttn_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    CQuery.QueryNow("INSERT INTO students(st_id, st_name, st_surname, st_group) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", dataGridView1);
                    CQuery.Query("students", dataGridView1);
                    break;
                case 1:
                    CQuery.QueryNow("INSERT INTO teachers(t_id, t_name, t_surname, t_predmet) values (" + textBox8.Text + ",'" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')", dataGridView2);
                    CQuery.Query("teachers", dataGridView2);
                    break;
                case 2:
                    CQuery.QueryNow("INSERT INTO materials(m_id, m_theme, m_rozdil) values (" + textBox12.Text + ",'" + textBox11.Text + "','" + textBox10.Text + "')", dataGridView3);
                    CQuery.Query("materials", dataGridView3);
                    break;
                case 3:
                    CQuery.QueryNow("INSERT INTO questions(q_id, q_question, q_answer) values (" + textBox14.Text + ",'" + textBox13.Text + "','" + textBox9.Text + "')", dataGridView4);
                    CQuery.Query("questions", dataGridView4);
                    break;
                case 4:
                    CQuery.QueryNow("INSERT INTO termins(term_id, term_name, term_value) values (" + textBox17.Text + ",'" + textBox16.Text + "','" + textBox15.Text + "')", dataGridView5);
                    CQuery.Query("termins", dataGridView5);
                    break;
                case 5:
                    CQuery.QueryNow("INSERT INTO tests(test_id, test_name, test_theme, test_predmet) values (" + textBox21.Text + ",'" + textBox20.Text + "','" + textBox19.Text + "','" + textBox18.Text + "')", dataGridView6);
                    CQuery.Query("tests", dataGridView6);
                    break;
                case 6:
                    CQuery.QueryNow("INSERT INTO test_results(r_id, r_test_name, r_student_name, r_student_group, r_result) values (" + textBox26.Text + ",'" + textBox25.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "')", dataGridView7);
                    CQuery.Query("test_results", dataGridView7);
                    break;

            }
            
        }

        private void edit_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        CQuery.QueryNow("UPDATE students SET st_name = '" + textBox2.Text + "',st_surname = '" + textBox3.Text + "', st_group = '" + textBox4.Text + "' WHERE st_id = " + textBox1.Text, dataGridView1);
                        CQuery.Query("students", dataGridView1);
                        break;
                    case 1:
                        CQuery.QueryNow("UPDATE teachers SET t_name = '" + textBox7.Text + "',t_surname = '" + textBox6.Text + "', t_predmet = '" + textBox5.Text + "' WHERE t_id = " + textBox8.Text, dataGridView2);
                        CQuery.Query("teachers", dataGridView2);
                        break;
                    case 2:
                        CQuery.QueryNow("UPDATE materials SET m_theme = '" + textBox11.Text + "',m_rozdil = '" + textBox10.Text + "' WHERE m_id = " + textBox12.Text, dataGridView3);
                        CQuery.Query("materials", dataGridView3);
                        break;
                    case 3:
                        CQuery.QueryNow("UPDATE questions SET q_question = '" + textBox13.Text + "',q_answer = '" + textBox9.Text + "' WHERE q_id = " + textBox14.Text, dataGridView4);
                        CQuery.Query("questions", dataGridView4);
                        break;
                    case 4:
                        CQuery.QueryNow("UPDATE termins SET term_name = '" + textBox16.Text + "',term_value = '" + textBox15.Text + "' WHERE term_id = " + textBox17.Text, dataGridView5);
                        CQuery.Query("termins", dataGridView5);
                        break;
                    case 5:
                        CQuery.QueryNow("UPDATE tests SET test_name = '" + textBox20.Text + "',test_theme = '" + textBox19.Text + "', test_predmet = " + textBox18.Text + " WHERE test_id = " + textBox21.Text, dataGridView6);
                        CQuery.Query("tests", dataGridView6);
                        break;
                    case 6:
                        CQuery.QueryNow("UPDATE test_results SET r_test_name = '" + textBox25.Text + "',r_student_name = '" + textBox24.Text + "', r_student_group = " + textBox23.Text + ", r_result = " + textBox22.Text + " WHERE r_id = " + textBox26.Text, dataGridView7);
                        CQuery.Query("test_results", dataGridView7);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Оберіть рядок для редагування!");
            }
            
        }
        private void remove_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        CQuery.QueryNow("DELETE FROM students WHERE st_id = " + textBox1.Text, dataGridView1);
                        CQuery.Query("students", dataGridView1);
                        break;
                    case 1:
                        CQuery.QueryNow("DELETE FROM teachers WHERE t_id = " + textBox8.Text, dataGridView2);
                        CQuery.Query("teachers", dataGridView2);
                        break;
                    case 2:
                        CQuery.QueryNow("DELETE FROM materials WHERE m_id = " + textBox12.Text, dataGridView3);
                        CQuery.Query("materials", dataGridView3);
                        break;
                    case 3:
                        CQuery.QueryNow("DELETE FROM questions WHERE q_id = " + textBox14.Text, dataGridView4);
                        CQuery.Query("questions", dataGridView4);
                        break;
                    case 4:
                        CQuery.QueryNow("DELETE FROM termins WHERE term_id = " + textBox17.Text, dataGridView5);
                        CQuery.Query("termins", dataGridView5);
                        break;
                    case 5:
                        CQuery.QueryNow("DELETE FROM tests WHERE test_id = " + textBox21.Text, dataGridView6);
                        CQuery.Query("tests", dataGridView6);
                        break;
                    case 6:
                        CQuery.QueryNow("DELETE FROM test_results WHERE r_id = " + textBox26.Text, dataGridView7);
                        CQuery.Query("test_results", dataGridView7);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Оберіть рядок для видалення!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }


        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox14.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            textBox13.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
        }



        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox17.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            textBox16.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            textBox15.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
        }


        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox21.Text = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            textBox20.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            textBox19.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
            textBox18.Text = dataGridView6.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox26.Text = dataGridView7.CurrentRow.Cells[0].Value.ToString();
            textBox25.Text = dataGridView7.CurrentRow.Cells[1].Value.ToString();
            textBox24.Text = dataGridView7.CurrentRow.Cells[2].Value.ToString();
            textBox23.Text = dataGridView7.CurrentRow.Cells[3].Value.ToString();
            textBox22.Text = dataGridView7.CurrentRow.Cells[4].Value.ToString();
        }

        

        private void button36_Click(object sender, EventArgs e)
        {
            CQuery.QueryNow("SELECT r_student_group, AVG(r_result) FROM test_results GROUP BY r_student_group", dataGridView8);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            CQuery.QueryFind("termins", "term_name", textBox27.Text, dataGridView9);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            CQuery.QueryFind("test_results", "r_student_name", textBox28.Text, dataGridView10);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            CQuery.QueryNow("SELECT r_student_name, r_student_group, AVG(r_result) FROM test_results GROUP BY r_student_name HAVING AVG(r_result) > 4.5", dataGridView11);
        }

        private void відключитисьВідБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sq1.QueryDrop();

        }
        private void підключитисьДоБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sq1.Query("students", dataGridView1);
        }
    }
}
