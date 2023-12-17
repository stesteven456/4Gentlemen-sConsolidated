using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;





namespace QuatroBigGuys
{
    public partial class Form1 : Form
    {
        DataTable table; // Declaring a DataTable variable named 'table'

        public Form1()
        {
            InitializeComponent(); // Initializing components on the form
        }


        // Method triggered when btnNew is clicked
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            txtName.Clear();
            txtUnits.Clear();
            txtPPU.Clear();
        }

        // Method triggered when btnLoad is clicked
        private void btnLoad_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex; // Get the index of the selected row in dataGridView1

            if (index > -1) // Check if a valid row is selected
            {
                // Populate text boxes with data from the selected row
                txtName.Text = table.Rows[index].ItemArray[0].ToString();
                txtUnits.Text = table.Rows[index].ItemArray[1].ToString();
                txtPPU.Text = table.Rows[index].ItemArray[2].ToString();
            }
        }

        // Method triggered when btnDelete is clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex; // Get the index of the selected row in dataGridView1

            table.Rows[index].Delete(); // Delete the selected row from the DataTable
        }

        // Declare totalPrice at the class level
        private double totalPrice;

        // Method triggered when btnSave is clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add data from text boxes to the DataTable as a new row
            table.Rows.Add(txtName.Text, txtUnits.Text, txtPPU.Text);

            // Clear text boxes after saving
            txtName.Clear();
            txtUnits.Clear();
            txtPPU.Clear();
        }

        // Method triggered when btnCalculate is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUnits.Text, out int numberOfUnits) && double.TryParse(txtPPU.Text, out double pricePerUnit))
            {
                totalPrice = numberOfUnits * pricePerUnit; // Assign totalPrice at the class level
                Console.WriteLine($"Total Price Calculated: {totalPrice}"); // Debug: Check if totalPrice is calculated correctly

                // Changing the displayed value of the label
                lblTotalDisplay.Text = $"${totalPrice.ToString()}";
                Console.WriteLine($"Label Text Updated: {lblTotalDisplay.Text}"); // Debug: Check if label text is updated

                // Additionally, you can check if the label is visible
                Console.WriteLine($"Label Visible: {lblTotalDisplay.Visible}");

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers for units and price per unit.");
            }
        }

        // Method triggered when btnFile is clicked
        private void btnFile_Click(object sender, EventArgs e)
        {
            // Create a FolderBrowserDialog object
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            // Show the dialog to the user
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                string folderPath = folderBrowser.SelectedPath;

                // Path to the file within the selected folder
                string filePath = Path.Combine(folderPath, "demo.txt");

                // Write data to the file
                using (TextWriter txt = new StreamWriter(filePath))
                {
                    txt.Write("Material: " + txtName.Text);
                    txt.WriteLine();
                    txt.Write("Number Of Units: " + txtUnits.Text);
                    txt.WriteLine();
                    txt.Write("Estimated Price Per Unit: " + txtPPU.Text);
                    txt.WriteLine();
                    txt.WriteLine("Total Price: $" + totalPrice); // Access totalPrice here
                }

                // Inform the user about the successful file creation
                MessageBox.Show("File created successfully in selected folder.", "File Created");
            }
            else
            {
                MessageBox.Show("Operation canceled or no folder selected.", "Canceled");
            }
        }










        // Method to get the debugger display information
        private string GetDebuggerDisplay()
        {
            return ToString(); // Returns a string representation for debugging purposes
        }


        // Method triggered when a cell's content in dataGridView1 is clicked
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method can be used to handle cell content clicks if needed
        }

        // Method triggered when text in a textbox changes
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            // This method can be used to handle text changes in textboxes if needed
        }


        // Method triggered when the form is loaded
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Initializing a new DataTable and adding columns to it
            table = new DataTable();
            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Units", typeof(String));
            table.Columns.Add("Price Per Unit", typeof(String));

            // Set dataGridView1's data source to the created DataTable
            dataGridView1.DataSource = table;

            // Customize column properties in the dataGridView1
            dataGridView1.Columns["Name"].Width = 100; // Set the width of the 'Name' column
            dataGridView1.Columns["Units"].Width = 100;
            dataGridView1.Columns["Price Per Unit"].Width = 150; // Hide the 'Estimate' column

            // Center-align column headers and change font style
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Franklin Gothic", 10, FontStyle.Bold);
            }
        }


    }
}

