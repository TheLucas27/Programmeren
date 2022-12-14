using System.Globalization;

namespace Opgave5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double SecondClass = 53.00;
        const double FirstClass = 87.46;
        const double Railrunner = 2.50;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            double totalPrice;
            double ticketPrice = 0;
            int amount = int.Parse(txtInputAmount.Text);
            int railrunnerAmount = int.Parse(txtInputRailrunners.Text);
            if (radSecondClass.Checked == true && amount != 0)
            {
                ticketPrice += SecondClass;
            }
            else if (radFirstClass.Checked == true && amount != 0)
            {
                ticketPrice += FirstClass;
            }
            totalPrice = (ticketPrice * amount) + (Railrunner * railrunnerAmount);
            txtOutputPrice.Text = $"{totalPrice:0.00}";
        }
    }
}