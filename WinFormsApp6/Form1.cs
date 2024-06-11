namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gg();
        }
        private void gg(int i=0)
        {
            if(i>10)
            {
                return;
            }
            if (true)
            {
                MessageBox.Show(i.ToString());
                gg(i + 1);
                return;
            }
            //
            //
            //
        }
    }
}
