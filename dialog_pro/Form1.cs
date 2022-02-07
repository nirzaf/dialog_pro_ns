using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dialog_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
            this.button1.ForeColor = this.colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            string fn;
            fn = this.folderBrowserDialog1.SelectedPath;
            if (fn=="")
            {
                MessageBox.Show("Please select your folder!");
            }
            else
            {
                this.textBox1.Text =fn ;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
           // this.button3.Font = this.fontDialog1.Font;
            // this.Font = this.fontDialog1.Font;
           // this.textBox2.Text = this.fontDialog1.Font.ToString();
           this.textBox2.Font = this.fontDialog1.Font;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            this.pictureBox1.Image =Image.FromFile(fn) ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string fn;
            fn = this.saveFileDialog1.FileName;
            this.textBox3.Text = fn;
        }
    }
}
