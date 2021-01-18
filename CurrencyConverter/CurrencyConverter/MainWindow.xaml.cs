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

            string FromCurrency = comboFromCurrency.Text;
            string ToCurrency = comboToCurrency.Text;

            // From USD.
            if (comboFromUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.27269, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.82752, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 73.1120, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.73551, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 103.86, ToCurrency);
                }
            }

            // From CAD
            if (comboFromCAD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.78514, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.64972, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 57.4029, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.57747, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 81.54, ToCurrency);
                }
            }

            // From EUR
            if (comboFromEUR.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.20748, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.53675, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 88.2813, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.88812, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 125.37, ToCurrency);
                }
            }

            // From INR
            if (comboFromINR.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.01363, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.01735, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.01128, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.01003, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.42, ToCurrency);
                }
            }

            // From GBP
            if (comboFromGBP.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.35818, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.72854, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.12418, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 99.2990, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 141.08, ToCurrency);
                }
            }

            // From JPY
            if (comboFromJPY.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.00963, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.01225, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.00797, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.70376, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.00708, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
            }

            lbDate.Content = string.Format("{0}", DateTime.Now);
        }
    }
}
