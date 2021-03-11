using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // check if any box is empty...
                if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                  DialogResult error = MessageBox.Show("Gelieve alles in te vullen", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (int.Parse(textBox4.Text) > int.Parse(textBox5.Text))
                {
                    DialogResult error = MessageBox.Show("De waarde voor start moet kleiner zijn dan de waarde voor einde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(error == DialogResult.OK)
                    {
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }
                } else
                {
                    int a = int.Parse(textBox1.Text);
                    int b = int.Parse(textBox2.Text);
                    int c = int.Parse(textBox3.Text);
                    int start = int.Parse(textBox4.Text);
                    int end = int.Parse(textBox5.Text);

                    for (int i = start; i < end + 1; i += 1)
                    {
                        int res = a * i * i + b * i + c;

                        resBox.Text += "For x = " + i + ", f(x) = " + res + "\r\n";
                    }
                }
            } catch(Exception err)
            {
                DialogResult error = MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(error == DialogResult.OK) { 
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
        }
    }
}
