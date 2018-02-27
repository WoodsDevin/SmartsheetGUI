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
using System.Text.RegularExpressions;

namespace SmartsheetGUI
{
    public partial class ClientForm : Form
    {
        private SmartsheetClient _client = null;
        private LoginForm _parent = null;
        private Sheet[] allSheets = null;
        private Sheet currentSheet = null;
        private UserProfile _user = null;

        public ClientForm()
        {
            InitializeComponent();
        }
        // Constructor gets passed the parent form
        // because I had a problem with the LoginForm process
        // not being closed.
        public ClientForm(SmartsheetClient client, LoginForm parent)
        {
            // Assign private fields
            _client = client;
            _parent = parent;

            // To do : Add a fancy error catch to make sure the Access Token was valid
            _user = _client.UserResources.GetCurrentUser();

            InitializeComponent();

        }
        // To close the hidden login form
        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Close();
        }

        // When the client form is loaded
        private void ClientForm_Load(object sender, EventArgs e)
        {
            allSheets = GetSheets();
            foreach (Sheet item in allSheets)
            {
                cboSheets.Items.Add(item.Name);
            }
            lblCurrentUser.Text = "Currently logged in as: " + _user.Email;
        }

        // When they select a sheet to work with
        private void cboSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboSheets.SelectedIndex;
            Sheet selected = allSheets[index];
            currentSheet = _client.SheetResources.GetSheet((long)selected.Id, null, null, null, null, null, null, null);

            // Show all info for the sheet.
            ShowSheetInfo(currentSheet);

        }
        // When they select whether to show "only unique columns."
        private void chkUniqueColumns_CheckedChanged(object sender, EventArgs e)
        {
            ShowSheetInfo(currentSheet);
        }

        // Make a new sheet
        private void btnMakeNewSheet_Click(object sender, EventArgs e)
        {
            NewSheetForm nsf = new NewSheetForm(_client);
            nsf.ShowDialog();
        }
        //=================================================================

        #region Misc Helper Methods

        // Returns all available sheets in an array
        private Sheet[] GetSheets()
        {
            // Get the results and make a new Sheet[] array
            PaginatedResult<Sheet> allSheets = _client.SheetResources.ListSheets(null, null);
            Sheet[] sheets = new Sheet[(int)allSheets.TotalCount - 1];


            for (int i = 0; i < allSheets.TotalCount - 1; i++)
            {
                long? id = allSheets.Data[i].Id;
                sheets[i] = _client.SheetResources.GetSheet((long)id, null, null, null, null, null, null, null);
            }
            return sheets;
        }
        // Shows misc. info of sheet passed in as argument.
        private void ShowSheetInfo(Sheet sheet)
        {
            // Shows all sheet info
            DateTime? created = sheet.CreatedAt;
            DateTime? modified = sheet.ModifiedAt;

            txtSheetName.Text = sheet.Name;
            txtCreated.Text = created.ToString();
            txtSheetID.Text = sheet.Id.ToString();
            txtModified.Text = modified.ToString();
            txtRowCount.Text = sheet.TotalRowCount.ToString();
            txtPermalink.Text = sheet.Permalink;

            // Populate Columns cbo
            FillColumns(chkUniqueColumns.Checked);
            FillRows();
        }
        #endregion
        #region Fill Methods
        private void FillColumns(bool showOnlyUniques)
        {
            IList<Column> cols = currentSheet.Columns;
            lstSheetView.Columns.Clear();
            foreach (Column col in cols)
            {
                // If they want to see all columns
                if (showOnlyUniques == false)
                {
                    lstSheetView.Columns.Add(col.Title);
                }
                // If they only want to see Uniques
                else
                {
                    // Use regular expressions to test the column name
                    string pattern = @"^Column";
                    Regex reg = new Regex(pattern);
                    if (reg.IsMatch(col.Title))
                    {
                        // Dont add it
                    }
                    else
                    {
                        // Add it                        
                        lstSheetView.Columns.Add(col.Title);
                    }
                }
            }
            // Auto size columns
            lstSheetView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void FillRows()
        {
            // Clear rows
            lstSheetView.Items.Clear();
            // Get all rows
            IList<Row> rows = currentSheet.Rows;
            foreach (Row row in rows)
            {
                // Get all cells inside each row
                IList<Cell> cells = row.Cells;

                // Second cellsArray for making a listViewItem
                // TODO: Change this and make it use the IList
                string[] cellsArray = new string[cells.Count];

                for (int i = 0; i < cells.Count - 1; i++)
                {
                    if (cells[i].Value != null)
                        cellsArray[i] = cells[i].Value.ToString();
                }
                // Make and add the listViewItem containing row data
                ListViewItem rowToAdd = new ListViewItem(cellsArray);
                lstSheetView.Items.Add(rowToAdd);
            }
        }


        #endregion

        private void btnOpenApiConsole_Click(object sender, EventArgs e)
        {
            ApiConsole apiConsole = new ApiConsole();
            apiConsole.Show();
        }
    }
}
