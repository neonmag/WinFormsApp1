namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(r.Next(0, ClientSize.Width), r.Next(0, this.ClientSize.Height));
        }
    }
}