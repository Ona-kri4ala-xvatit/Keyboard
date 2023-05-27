namespace Keyboard
{
    public partial class Keyboard : Form
    {
        public Keyboard()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Space ")
            {
                richTextBox.AppendText(" ");
            }
            else if ((sender as Button).Text == "Backspace")
            {
                if (string.IsNullOrEmpty(richTextBox.Text))
                {
                    return;
                }
                else
                {
                    string str = richTextBox.Text;
                    richTextBox.Text = str.Remove(str.Length - 1);
                }
            }
            else 
            {
                richTextBox.AppendText((sender as Button).Text);
            }
        }
    }
}