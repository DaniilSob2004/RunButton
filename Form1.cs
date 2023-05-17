namespace RunButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Run Button";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();

            int x = r.Next(0, this.ClientSize.Width - Click.Width);
            int y = r.Next(0, this.ClientSize.Height - Click.Height);

            Click.Location = new Point(x, y);
        }
    }
}