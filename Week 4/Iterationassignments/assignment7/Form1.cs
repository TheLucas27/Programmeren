namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtInput.Text);
            int X = 0;
            for (int i = 0; i <= size; i++)
            {
                for (int j = X; j <= size; j++)
                {
                    lblX.Text = j.ToString("X");
                }
            }
        }
    }
}