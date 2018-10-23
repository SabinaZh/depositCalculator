using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            total.Controls[0].Visible = false;
            //dateTimePicker2.Controls[1].Visible = false;
            dateTimePicker2.ShowUpDown = true;
            
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double startsum = Convert.ToDouble(startcount.Value);
            double procent = Convert.ToDouble(percent.Value);
            int srok = Convert.ToInt32(years.Value);

            procent = procent / 100;

           double period = procent / 12;
                      
           double totalsum = startsum * Math.Pow((1 + period), srok);
            total.Text= Convert.ToString(Math.Round(totalsum, 2));

            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(srok);
        }
    }
}
