// 22.7 Thad__Swint

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballDatabase
{
    public partial class playersTable : Form
    {
        public playersTable()
        {
            InitializeComponent();
        }
        // Entity framework
        private Baseball.BaseballEntities dbcontext = null;

        private void RefreshAll()
        {
            // Dipose of old context if any
            if (dbcontext != null)
                dbcontext.Dispose();

            // New DBcontext
            dbcontext = new Baseball.BaseballEntities();
           
            // LINQ order 
            dbcontext.Players
                .OrderBy(entry => entry.LastName)
                .ThenBy(entry => entry.FirstName)
                .Load();
            // Specify datasource for binding
            playerBindingSource.DataSource = dbcontext.Players.Local;
            playerBindingSource.MoveFirst();
            lastNameTextBox.Clear();
        }
        private void playersTable_Load(object sender, EventArgs e)
        {
            // Set min and max 
            minimumTextBox.Text = "0.000";
            maximumTextBox.Text = "1.000";
            RefreshAll();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Query for last name search
            var lastNameQuery =
                from player in dbcontext.Players
                where player.LastName.StartsWith(lastNameTextBox.Text)
                orderby player.LastName, player.FirstName
                select player;
            // Display our matches
            playerBindingSource.DataSource = lastNameQuery.ToList();
            playerBindingSource.MoveFirst();

            // Disable nav
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Return full list
            searchButton.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            RefreshAll();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Handle empty strings
                if (minimumTextBox.Text == "")
                {
                    minimumTextBox.Text = "0.000";
                }
                if (maximumTextBox.Text == "")
                {
                    maximumTextBox.Text = "1.000";
                }
                string min = minimumTextBox.Text;
                string max = maximumTextBox.Text;
                decimal mini = decimal.Parse(min);
                decimal maxi = decimal.Parse(max);
                // Query of batting averages 
                var searchQuery =
                    from player in dbcontext.Players
                    where (player.BattingAverage >= mini) && (player.BattingAverage <= maxi)
                    orderby player.BattingAverage
                    select player;
                // Return our matches
                playerBindingSource.DataSource = searchQuery.ToList();
                playerBindingSource.MoveFirst();

                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;

            }
            catch (System.FormatException)
            {

                MessageBox.Show("Only decimal values:" +
                    "\nx.xxx");
            }
            minimumTextBox.Clear();
            maximumTextBox.Clear();
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow letters in last name text box
            searchButton.Enabled = false;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void minimumTextBox_TextChanged(object sender, EventArgs e)
        {
            // Prevent values greater than our cieling and lower than our floor
            if (decimal.TryParse(minimumTextBox.Text, out decimal value))
            {
                if (value > 1)
                {
                    minimumTextBox.Text = "1.000";
                }
                else if (value < 0)
                {
                    minimumTextBox.Text = "0.000";
                }
            }
        }

        private void maximumTextBox_TextChanged(object sender, EventArgs e)
        {
            // Prevent values greater than our cieling and lower than our floor
            if (decimal.TryParse(maximumTextBox.Text, out decimal value))
            {
                if (value > 1)
                {
                    minimumTextBox.Text = "1.000";
                }
                else if (value < 0)
                {
                    minimumTextBox.Text = "0.000";
                }
            }

        }
    }
}
