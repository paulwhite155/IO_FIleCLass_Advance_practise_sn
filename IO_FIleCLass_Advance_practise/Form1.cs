using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_FIleCLass_Advance_practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.fileName_textBox1.Text = this.openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(this.fileName_textBox1.Text)==true )
            {
                this.textBox2.Text = System.IO.File.GetCreationTime(this.fileName_textBox1.Text).ToString();
            }
            else
            {
                MessageBox.Show("no file exists");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fileName_textBox1.Text) == true)
            {
                this.textBox1.Text = System.IO.File.GetLastWriteTime(this.fileName_textBox1.Text).ToString();
            }
            else
            {
                MessageBox.Show("no file exists");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fileName_textBox1.Text) == true)
            {
                this.textBox3.Text = System.IO.File.GetLastAccessTime(this.fileName_textBox1.Text).ToString();
            }
            else
            {
                MessageBox.Show("no file exists");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fileName_textBox1.Text) == true)
            {
                this.textBox4.Text = System.IO.Path.GetFileName(this.fileName_textBox1.Text);
            }
            else
            {
                MessageBox.Show("no file exists");
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fileName_textBox1.Text) == true)
            {
                this.textBox5.Text = System.IO.Path.GetExtension(this.fileName_textBox1.Text);
            }
            else
            {
                MessageBox.Show("no file exists");
            }



            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.fileName_textBox1.Text) == true)
            {
                this.textBox6.Text = System.IO.Path.GetFullPath(this.fileName_textBox1.Text);
            }
            else
            {
                MessageBox.Show("no file exists");
            }

        }
    }
}
