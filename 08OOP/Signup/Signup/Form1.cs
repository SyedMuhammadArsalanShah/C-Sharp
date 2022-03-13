using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "Data Source=.;Initial Catalog=Signup2;Integrated Security=True";
            SqlConnection sql = new SqlConnection(data);


            string name = textBox1.Text;
            string email = textBox2.Text;
            string pass = textBox3.Text;
            string contact = textBox4.Text;
            string address = textBox5.Text;

            if (name !=string.Empty|| email != string.Empty && pass != string.Empty|| contact != string.Empty|| address != string.Empty)
            {
                
                sql.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sql;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into info2 (Name, Email , Pass,  Contact , Address )" +
                    " Values('" + name + "' ,'" + email + "','" + pass + "','" + contact + "','" + address + "')";

                command.ExecuteNonQuery();



                MessageBox.Show("Account Successfully created");
            }
            else
            {
                MessageBox.Show("Error");
            }

            sql.Close();
        }
    }
}
