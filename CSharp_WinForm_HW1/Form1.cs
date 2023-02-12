namespace CSharp_WinForm_HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Baku_click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Baku;
        }
        private void NewYork_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.NewYork;
        }
    }
}