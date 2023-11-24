using System;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class Form1 : Form
    {
        private const string ValidUsername = "radkaeqka";
        private const string ValidPassword = "radkaeqka123";

        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == ValidUsername && password == ValidPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Code for label click event
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
