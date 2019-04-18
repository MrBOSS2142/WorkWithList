using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();
        Random rnd = new Random();
        private void Generation(object sender, EventArgs e)
        {
            try 
            {
                textBox2.Clear();
                textBox3.Clear();
                list.Clear();
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    list.Add(rnd.Next(10,500));
                    textBox2.Text += "Человек №  " + list[i] + "\r\n";
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void buttonInAscendingOrder(object sender, EventArgs e)
        {
            textBox3.Clear();
            var z = list.OrderBy(s => s);
            foreach (var elem in z)
            {
                textBox3.Text += "Человек №  " + elem + "\r\n";
            }
        }

        private void buttonInDescendingOrder(object sender, EventArgs e)
        {
            textBox3.Clear();
            var z = list.OrderByDescending(s => s);
            foreach (var elem in z)
            {
                textBox3.Text += "Человек №  " + elem + "\r\n";
            }
        }

        private void buttonMaxClick(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.Text += "Человек №  " + list.Max() + "\r\n";
        }

        private void buttonMinClick(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.Text += "Человек №  " + list.Min() + "\r\n";
        }

        private void buttonFirstClick(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.Text += "Человек №  " + list.First() + "\r\n";
        }

        private void buttonLastClick(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.Text += "Человек №  " + list.Last() + "\r\n";
        }
    }
}
