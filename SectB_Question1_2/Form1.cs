namespace SectB_Question1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            // Get user name
            string userName = txtName.Text;

            // Validate
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            // Greet the user
            MessageBox.Show($"Hello {userName}!");
        }
    }
}
