namespace Task4
{
    public partial class NumberForm : Form
    {
        public NumberForm()
        {
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
                TextBox.Text += button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }
    }
}
