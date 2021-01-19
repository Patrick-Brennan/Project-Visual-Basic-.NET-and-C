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


                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.89, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 24.00, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.000027, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.00079, ToCurrency);
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

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.7, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 18.85, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.000021, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.00062, ToCurrency);
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

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.08, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 29.01, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.000033, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.00096, ToCurrency);
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

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.012, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.33, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.0000011, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.000011, ToCurrency);
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

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.21, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 32.63, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.000037, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.0011, ToCurrency);
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

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.0086, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.23, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.0000010, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.0000076, ToCurrency);
                }
            }


            //CHF
            if (comboFromCHF.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.12, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1.43, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.93, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 82.16, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.83, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 116.50, ToCurrency);
                }

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 26.95, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.000031, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.00088, ToCurrency);
                }
            }

            //CUP
            if (comboFromCUP.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.042, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.053, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.034, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 3.05, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.031, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 4.32, ToCurrency);
                }

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.037, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.0000011, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.000032, ToCurrency);
                }
            }

            //BTC-USD
            if (comboFromBTCUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 36815.70, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 46867.67, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 30443.82, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 2694725.16, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 27224.34, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 3844752.60, ToCurrency);
                }

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 32998.92, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 889318.56, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency * 28.37, ToCurrency);
                }
            }

            //ETH
            if (comboFromETHUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1402.83, ToCurrency);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}$ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1788.88, ToCurrency);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}€ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1157.69, ToCurrency);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}₹ in {3}",
                        txtAmount.Text, FromCurrency, currency * 102752.54, ToCurrency);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}£ in {3}",
                        txtAmount.Text, FromCurrency, currency * 1031.20, ToCurrency);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}¥ in {3}",
                        txtAmount.Text, FromCurrency, currency * 146014.59, ToCurrency);
                }

                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}CHF in {3}",
                        txtAmount.Text, FromCurrency, currency * 1246.96, ToCurrency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}₱ in {3}",
                        txtAmount.Text, FromCurrency, currency * 33709.68, ToCurrency);
                }
                if (combotoBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}₿ in {3}",
                        txtAmount.Text, FromCurrency, currency * 0.038, ToCurrency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in {1} has been converted to {2:n2}Ξ in {3}",
                        txtAmount.Text, FromCurrency, currency, ToCurrency);
                }
            }

            lbDate.Content = string.Format("{0}", DateTime.Now);
        }
    }
}
