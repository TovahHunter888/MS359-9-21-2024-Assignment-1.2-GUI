using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Tovah Hunter
 * Assignment 1.2 GUI
 * week 1
 * Renamed Form1, added a BUtton, LAbel, Checkbox, RAdio Button, and Tooltip
 * Notes: Remeber to double click each radio button. 
 *        This will input the appropriate code on the form
 * Estimate 8 hours
 * Actual 7 hours
 * Analysis Paragraph: 
 * I estimated the project would take eight hours.
 * My actual project completiontime was shorter because I rewatched each lecture video while completing the project.
 * This helps me avoid mistakes, understand the design, and coding statements better. I did not use all the components 
 * were explained in lecture. However, I want to incorporate images as the semester progresses. I'm excited to use functions 
 * that can bring my fashion game idea to life. I also should mention that completing this project may have taken a shorter time.
 * Primarly with the radio buttons. This occurred after creating and pushing a Git repository to GitHub
 * from Visual Studio. After downloading the code from GitHub there were messages stating files were missing.
 * I didn't figure out why this happened. Ultimately uploading the project folder directly into GitHub worked simply fine.
 */
namespace MS359_9_21_2024_Assignment_1._2_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Entry into Retro Emporium
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!");
        }
        // Womans Vintage Clothing styles 
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Check boxes show popup describing each style
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Trendy!");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Delightful Approach!");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Proper Fashion!");
        }
        // Groupbox with radio buttons allowing the size selection
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Feedback Button providing size information based on which size is selected
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                MessageBox.Show("Eaxact Fit!");
            }
            else
            {
                MessageBox.Show("Plus Size!");
            }
        }
    }
}
