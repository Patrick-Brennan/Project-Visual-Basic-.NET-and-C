using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            double currency;
            if (!double.TryParse(txtAmount.Text, out currency))
            {
                return;
            }

            // Interbank.
            if (percent0.IsSelected == true)
            {
            }
            if (percent1.IsSelected == true)
            {
                currency = currency * 0.99;
            }
            if (percent2.IsSelected == true)
            {
                currency = currency * 0.98;
            }
            if (percent3.IsSelected == true)
            {
                currency = currency * 0.97;
            }
            if (percent4.IsSelected == true)
            {
                currency = currency * 0.96;
            }
            if (percent5.IsSelected == true)
            {
                currency = currency * 0.95;
            }

            // From USD.
            if (comboFromUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in in US Dollars (USD) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.27269);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in in US Dollars (USD) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.82752);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in in US Dollars (USD) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 73.1120);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in in US Dollars (USD) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.73551);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in in US Dollars (USD) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 103.86);
                }
            }

            // From CAD
            if (comboFromCAD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.78514);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.64972);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 57.4029);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.57747);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 81.54);
                }
            }

            // From EUR
            if (comboFromEUR.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1.20748);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.53675);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 88.2813);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.88812);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 125.37);
                }
            }

            // From INR
            if (comboFromINR.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.01363);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 0.01735);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.01128);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.01003);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 1.42);
                }
            }

            // From GBP
            if (comboFromGBP.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1.35818);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.72854);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 1.12418);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 99.2990);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 141.08);
                }
            }

            // From JPY
            if (comboFromJPY.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.00963);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 0.01225);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.00797);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 0.70376);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.00708);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency);
                }
            }

            lbDate.Content = string.Format("{0}", DateTime.Now);
        }
    }
}
