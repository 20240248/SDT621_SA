using static System.Net.Mime.MediaTypeNames;

namespace SectionC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get input values
            string mobileCode = txtCode.Text;
            string make = txtMake.Text;
            string Quantity = txtQuantity.Text;

            // Validate input
            if (String.IsNullOrEmpty(mobileCode) || String.IsNullOrEmpty(make) || String.IsNullOrEmpty(Quantity))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Add mobile phone to list
            tblMobilePhones.Items.Add($"{mobileCode} - {make} - {Quantity}");

            lblOutput.Text = $"Record added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get input
            string mobileCode = txtCode.Text;

            if (string.IsNullOrEmpty(mobileCode))
            {
                MessageBox.Show("Please enter a mobile code to delete.");
                return;
            }

            // Find item to delete
            var itemToDelete = tblMobilePhones.Items.Cast<string>().FirstOrDefault(item => item.Contains(mobileCode));

            if (itemToDelete != null)
            {
                // Remove item
                tblMobilePhones.Items.Remove(itemToDelete);
                lblOutput.Text = "Record Found";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Question does not specify what to do if record is found, just says to display "Record Deleted"

            string mobileCode = txtCode.Text;

            if (String.IsNullOrEmpty(mobileCode))
            {
                MessageBox.Show("Please enter a mobile code to find.");
                return;
            }

            // Find item
            var itemToFind = tblMobilePhones.Items.Cast<string>().FirstOrDefault(item => item.Contains(mobileCode));

            // Output
            if (itemToFind != null)
            {
                lblOutput.Text = "Record Deleted";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }
    }
}
