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
            //richTextBox.Text += (sender as string[]).ToArray();
                RichTextBox richTextBox2 = sender as RichTextBox;
            richTextBox.Text = richTextBox2.Text;
            //if (sender is RichTextBox rtxt)
            //{
            //}
        }
    }
}