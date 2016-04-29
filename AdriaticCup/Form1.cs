using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdriaticCup
{
    public partial class Form1 : Form
    {
        Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = listBox1.Items;
            int n = list.Count;
            if (n == 0) return;
            
            int broj1 = rand.Next(n);

            MessageBox.Show(list[broj1].ToString(), "Izvučen je tim:");

            foreach (Control ctr in this.Controls)
            {
                if (ctr is Label)
                    if (ctr.Name == "label"+(27-n))
                        ctr.Text = list[broj1].ToString();
                        
            }
            list.RemoveAt(broj1);

       //     label27.Text = list.Count.ToString();
        }

    }
}
