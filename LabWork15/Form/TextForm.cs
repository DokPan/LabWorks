using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Task3
{
    public partial class TextForm : Form
    {
        
        public TextForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ReplaceForm form = new ReplaceForm(UpdateText);
            form.ShowDialog();
        }
        public void UpdateText(string oldText, string newText)
        {
            MainTextBox.Text = MainTextBox.Text.Replace(oldText, newText);
        }
    }
}
