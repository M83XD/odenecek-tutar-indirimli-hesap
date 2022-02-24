using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(textBox1.Text);
            for (int i = 1; i <= deger; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                }
                if (i % 5 == 0)
                {
                    listBox2.Items.Add(i);
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox3.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tpUcret = 0;
            double tpUcret2 = 0;
            double tutar = double.Parse(textBox2.Text);
            double tutar2 = double.Parse(textBox2.Text);
            if (checkBox1.Checked == true)
            {
                tpUcret = tutar - tutar * 20 / 100;
            }
            else
            {
                tpUcret = tutar;
            }
            label7.Text = "Ödenecek Toplam Tutar: " + tpUcret;

            if (checkBox2.Checked == true)
            {
                tpUcret = tutar2 - tutar2 * 30 / 100;
            }
            else
            {
                tpUcret2 = tutar2;
            }
            label7.Text = "Ödenecek Toplam Tutar: " + tpUcret;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            
                checkBox2.Checked = false;
            



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox1.Checked = false;
            
        }
    }
}
  

