using JokeManagerNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int status = JokeManager.SaveJoke(textbox_UCID.Text, textbox_Joke.Text);
            if (status != -1)
            {
               MessageBox.Show("Query Unsuccseful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                textbox_Joke.Text = "";
                textbox_UCID.Text = "";
                MessageBox.Show("Query Succesful", "Success");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
