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
    }
}
