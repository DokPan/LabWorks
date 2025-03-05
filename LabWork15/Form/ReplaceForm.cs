namespace Task3
{
    public partial class ReplaceForm : Form
    {
        private Action<string, string> replaceAction;
        public ReplaceForm(Action<string, string> replaceAction)
        {
            InitializeComponent();
            this.replaceAction = replaceAction;
        }

        private void ButtonReplace_Click(object sender, EventArgs e)
        {
            replaceAction(oldText.Text, newText.Text);
            this.Close();
        }
    }
}
