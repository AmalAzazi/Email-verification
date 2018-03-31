using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace yahoo_mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 31; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }

            for (int i = 1982; i <= 2014; i++)
            {
                comboBox4.Items.Add(i.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you forget your password or username. We can send information to this number to help. we'll also text you a link to use mail on your phone.","i",MessageBoxButtons.OK ,MessageBoxIcon.Asterisk  );

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Regex.IsMatch(textBox1.Text, @"^[A-Z a-z]+$"))
            {
                label12.ForeColor = Color.Green;
                label12.Text = "First name is valid";
                pictureBox1.Image = Properties.Resources.Good;
            }

            else
            {
                label12.ForeColor = Color.Red;
                label12.Text = "Numbers and special characters are not allowed.";
                pictureBox1.Image = Properties.Resources.bad;
            }

            if (Regex.IsMatch(textBox2.Text, @"^[A-Z a-z]+$"))
            {
                label13.ForeColor = Color.Green;
                label13.Text = "Last name is valid";
                pictureBox2.Image = Properties.Resources.Good;
            }
            else
            {
                label13.ForeColor = Color.Red;
                label13.Text = "Numbers and special characters are not allowed.";
                pictureBox2.Image = Properties.Resources.bad;
            }
            if (Regex.IsMatch(textBox3.Text, @"^[\w]+[.]+[\w]+[@]{1}[\w]+[.]{1}[\w]+$"))
            {
                label14.ForeColor = Color.Green;
                label14.Text = "Email is valid";
                pictureBox3.Image = Properties.Resources.Good;
            }
            else
            {
                label14.ForeColor = Color.Red;
                label14.Text = "Email is InValid";
                pictureBox3.Image = Properties.Resources.bad;
            }
            if (textBox4.Text == "")
            {
                label16.ForeColor = Color.Red;
                label16.Text = "Please type a password.";
                pictureBox4.Image = Properties.Resources.bad;
            }
            else
            {
                if (textBox4.Text.Length <= 9)
                {
                    label16.ForeColor = Color.Green;
                    label16.Text = "week password";
                    pictureBox4.Image = Properties.Resources.Good;
                }
                else
                {
                    label16.Text = "strong password";
                }
            }
            if (Regex.IsMatch(textBox5.Text, @"^[\d]{9}$"))
            {
                label15.ForeColor = Color.Green;
                label15.Text = "Number is Valid";
                pictureBox5.Image = Properties.Resources.Good;
            }
            else
            {
                label15.ForeColor = Color.Red;
                label15.Text = "Number is InValid";
                pictureBox5.Image = Properties.Resources.bad;
            }
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
