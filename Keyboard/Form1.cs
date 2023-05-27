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
            else 
            {
                richTextBox.AppendText((sender as Button).Text);
            }
        }
    }
}