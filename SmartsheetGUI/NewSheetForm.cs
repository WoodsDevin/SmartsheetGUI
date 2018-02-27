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
using Smartsheet.Api.Models;

namespace SmartsheetGUI
{
    public partial class NewSheetForm : Form
    {
        private SmartsheetClient client;
        public NewSheetForm()
        {
            InitializeComponent();
        }
        // The newSheetForm accepts a client from the ClientForm
        public NewSheetForm(SmartsheetClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void btnCreateSheet_Click(object sender, EventArgs e)
        {
            MakeNewSheet();
        }

        private void MakeNewSheet()
        {
            client.SheetResources.CreateSheet(new Sheet()
            {
                Name = "Test Sheet",
                Columns = new Column[]
                {
                    new Column
                    {
                        Title = "Test Column 1",
                        Primary = true,
                        Type = ColumnType.TEXT_NUMBER                   
                    },
                    new Column
                    {
                        Title = "Test Column 2",
                        Primary = false,
                        Type = ColumnType.TEXT_NUMBER
                    },
                }
            });
        }

        
    }
}
