using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_IndexOf_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        string secilen_eleman;

        private void Form1_Load(object sender, EventArgs e)
        {
            isimler[0] = "Negan";
            isimler[1] = "Rick";
            isimler[2] = "Daryl";
            isimler[3] = "Morgan";
            isimler[4] = "Rosita";
            foreach (string liste in isimler)
            {
                listBox1.Items.Add(liste);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen_eleman = (string)listBox1.SelectedItem;
            textBox1.Text = secilen_eleman;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(isimler, secilen_eleman);
            if (index == -1)
            {
                MessageBox.Show("Seçilen isimde hata var.");
                return;
            }
            isimler[index] = textBox1.Text;
            MessageBox.Show("Güncellendi.");
            listBox1.Items.Clear();
            foreach (string liste in isimler)
            {
                listBox1.Items.Add(liste);
            }
            /*
            if (index == -1)
            {
                MessageBox.Show("Seçilen isimde hata var.");
            }
            else
            {
                isimler[index] = textBox1.Text;
                MessageBox.Show("Güncellendi.");
                listBox1.Items.Clear();
                foreach (string liste in isimler)
                {
                listBox1.Items.Add(liste);
                }
            } 
            */ //return; olmazsa böyle yazılır aynı işi yapar.
        }
    }
}