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
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.27269);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.82752);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 73.1120);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.73551);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 103.86);
                }
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.89);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 24.00);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000027);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00079);
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
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.7);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 18.85);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000021);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00062);
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
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 1.08);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 29.01);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000033);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00096);
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
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.012);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 0.33);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.0000011);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.000011);
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
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 1.21);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}₱ in {Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 32.63);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000037);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.0011);
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
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.0086);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 0.23);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.0000010);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.0000076);
                }
            }

            //CHF
            if (comboFromCHF.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1.12);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.43);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.93);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 82.16);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.83);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 116.50);
                }
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 26.95);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000031);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00088);
                }
            }

            //CUP
            if (comboFromCUP.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.042);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 0.053);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.034);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 3.05);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.031);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 4.32);
                }
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.037);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.0000011);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.000032);
                }
            }

            //BTC-USD
            if (comboFromBTCUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 36815.70);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 46867.67);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 30443.82);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 2694725.16);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 27224.34);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 3844752.60);
                }
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 32998.92);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 889318.56);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 28.37);
                }
            }

            //ETH
            if (comboFromETHUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1402.83);
                }
                if (comboToCAD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1788.88);
                }
                if (comboToEUR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 1157.69);
                }
                if (comboToINR.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 102752.54);
                }
                if (comboToGBP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 1031.20);
                }
                if (comboToJPY.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 146014.59);
                }
                if (comboToCHF.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 1246.96);
                }
                if (comboToCUP.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 33709.68);
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.038);
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    lbResult.Content = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency);
                }
            }

            lbDate.Content = string.Format("{0}", DateTime.Now);
        }
    }
}