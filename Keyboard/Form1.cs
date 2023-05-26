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
            richTextBox.AppendText((sender as Button).Text);
        }
    }
}