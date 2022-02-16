using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ybirth = Convert.ToInt32(byear.Text);
            int Ycurrent = Convert.ToInt32(cyear.Text);
            int cal = Ycurrent - Ybirth;
            int month = cal * 12;
            int weeks = month * 4;
            int days = weeks * 7;
            int hours = days * 24;
            int min = hours * 60;
            int sec = min * 60;

            label3.Text = cal.ToString();//age
            label4.Text = month.ToString();//months
            label5.Text = weeks.ToString();//weeks
            label6.Text = days.ToString();//days
            label7.Text = hours.ToString();//hours
            label8.Text = min.ToString();//min
            label9.Text = sec.ToString();//sec




        }
    }
}
