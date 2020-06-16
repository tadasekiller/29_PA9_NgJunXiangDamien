using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_PA9_NgJunXiangDamien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            try
            {
                double AmountEntered;
                double convertedvalue;
                if ((rdb_USdollars.Checked == false) && (rdb_JapYen.Checked == false))
                {
                    lbl_error.Text = "Select at least one type of currency";
                }
                if (rdb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 0.74;
                    txt_convertedamt.Text = convertedvalue.ToString();
                }
                if (rdb_JapYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 81.97;
                    txt_convertedamt.Text = convertedvalue.ToString();
                }
            }
            catch
            {
                lbl_error.Text = "Enter a valid amount.";
                txt_amount.Text = "";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "";
            txt_convertedamt.Text = "";
            lbl_error.Text = "";
        }
    }
}
