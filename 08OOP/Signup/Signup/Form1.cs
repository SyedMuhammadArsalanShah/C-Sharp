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
            string laiba = "Data Source=.;Initial Catalog=Signup3;Integrated Security=True";
           SqlConnection connection=new SqlConnection(laiba);           


            string name, email, pass, contact, address;
            name =textBox1.Text;
            email=textBox2.Text;
            pass=textBox3.Text;
            contact=textBox4.Text;
            address=textBox5.Text;

            if (name != string.Empty || contact != string.Empty || address != string.Empty)
            {
                if (email != string.Empty && pass != string.Empty)
                {
                      connection.Open();
                      SqlCommand  command = new SqlCommand();
                      command.Connection = connection;
                      command.CommandType = CommandType.Text;
                      command.CommandText = "insert into info (Name, Email , Pass,  Contact , Address ) Values('" + name + "','" + email + "','" + pass + "','" + contact + "','" + address+ "')";
                       command.ExecuteNonQuery();


                    MessageBox.Show("Account Successfully created");}
                else
                {MessageBox.Show("Error"); }
            }
            else
            { MessageBox.Show("Error"); }


          connection.Close();
        }
    }
}
