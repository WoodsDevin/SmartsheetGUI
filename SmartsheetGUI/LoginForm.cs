using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smartsheet.Api;

namespace SmartsheetGUI
{
    public partial class LoginForm : Form
    {
        public static string Token;
        public LoginForm()
        {
            InitializeComponent();
            txtAccessToken.Text = "qtepuuhpc9mmdlzzen5r571e6v";
        }

        private async void btnSubmitToken_Click(object sender, EventArgs e)
        {
            //string token = txtAccessToken.Text;
            Token = txtAccessToken.Text;
            // Build the client
            SmartsheetClient client = null;
            
            try
            {
                // Build the client in a thread to avoid UI Lock
                await Task.Factory.StartNew(() => client = new SmartsheetBuilder().SetAccessToken(Token).Build());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // If the client has been successfully created
            if (client != null)
            {
                // Create a client form and show it
                ClientForm clientForm = new ClientForm(client, this);
                clientForm.Show();

                // Hide the login form
                this.Visible = false;

            }
        }

    }
}
