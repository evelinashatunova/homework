using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Shatunova_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButtonJPG.Checked = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(listBox1.SelectedItem.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                listBox1.Refresh();
                string folder = folderBrowserDialog1.SelectedPath;
                label1.Text = folder;
                foreach (string i in Directory.GetFiles(folder))
                {
                    if (i.EndsWith(".jpg") == true || i.EndsWith(".png") == true || i.EndsWith(".bmp") == true)
                    {
                        listBox1.Items.Add(i);
                    }
                }


            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { };
            foreach (string l in listBox1.Items)
                list.Add(l);
            listBox1.Items.Clear();
            foreach (string i in list)
            {
                if (i.EndsWith(".jpg") == true)
                {
                    listBox1.Items.Add(i);
                }
            }
            foreach (string l in list)
                listBox1.Items.Add(l);
            listBox1.Refresh();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { };
            foreach (string l in listBox1.Items)
                list.Add(l);
            listBox1.Items.Clear();
            foreach (string i in list)
            {
                if (i.EndsWith(".png") == true)
                {
                    listBox1.Items.Add(i);
                }
            }
            foreach (string l in list)
                listBox1.Items.Add(l);
            listBox1.Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { };
            foreach (string l in listBox1.Items)
                list.Add(l);
            listBox1.Items.Clear();
            foreach (string i in list)
            {
                if (i.EndsWith(".bmp") == true)
                {
                    listBox1.Items.Add(i);
                }
            }
            foreach (string l in list)
                listBox1.Items.Add(l);
            listBox1.Refresh();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
