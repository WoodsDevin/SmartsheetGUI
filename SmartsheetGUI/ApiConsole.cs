using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartsheetGUI
{
    public partial class ApiConsole : Form
    {
        public ApiConsole()
        {
            InitializeComponent();
        }


        // Method to make a request to an API
        // This method will return a string containing the JSON response

        // TODO : Make it return JSON object
        private string Request(string url)
        {
            // Emtpy placeholder
            string returnResponse = "";

            // Create request and add the headers
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add($"Authorization: Bearer {LoginForm.Token}");
            request.Method = "GET";

            // Get the response
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Get reponse stream
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        // Create a streamreader and assign
                        using(StreamReader sr = new StreamReader(responseStream))
                        {
                            returnResponse = sr.ReadToEnd();
                        }                        
                    }
                }
            }
            // Return
            return returnResponse;
        }

        // Clean this up.
        private string Format(string input)
        {
            // For formatting, you have to Deserialize the JSON string object, 
            // and then Reserialize it with Indented Formatting
            object str = JsonConvert.DeserializeObject(input);
            return JsonConvert.SerializeObject(str, Formatting.Indented);            
        }

        private void btnGetApiResp_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string response = Format(Request(url));
            richTextBox1.Text = response;
        }

        private void lblExampleCalls_Click(object sender, EventArgs e)
        {
            string[] calls = new string[6]
            {
                @"https://api.smartsheet.com/2.0/users/me",
                @"https://api.smartsheet.com/2.0/sheets/7705909259462532",
                @"https://api.smartsheet.com/2.0/home",
                @"https://api.smartsheet.com/2.0/search?query=devin",
                @"https://api.smartsheet.com/2.0/templates/public",
                @"https://api.smartsheet.com/2.0/serverinfo"
            };
            Random rand = new Random();
            txtUrl.Text = calls[rand.Next(0, 5)];

        }
    }
}
