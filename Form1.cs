namespace WinFormsTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Testable logic method
        public string CreateGreeting(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return "Hello, " + name + "!";
        }

        // Handles the main "Greet" button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input before greeting
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter your name first.", "Missing Name");
                return;
            }

            // Show greeting message
            MessageBox.Show("Hello, " + txtInput.Text + "!", "Greeting");

            // Reset UI for next input
            txtInput.Clear();
            txtInput.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Updates preview label and enables/disables the button
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblPreview.Text = "Preview: Hello, " + txtInput.Text;

            // Enable greet button only when input is valid
            btnGreet.Enabled = !string.IsNullOrWhiteSpace(txtInput.Text);
        }

        // Clears the UI when Reset button is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblPreview.Text = "Preview:";
            txtInput.Focus();
        }

        // Opens the About window
        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Create and show the About window
            AboutForm about = new AboutForm();
            about.ShowDialog(); // Modal window
        }

    }
}
