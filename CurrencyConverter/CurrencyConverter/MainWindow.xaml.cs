using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        public string fileName = @"..\..convertdata.txt";
        private List<Conversion> convertList = new List<Conversion>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lvConvert_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = lvConvert.SelectedItem;
            if (selectedItem is Conversion)
            {
                Conversion conversion = (Conversion)lvConvert.SelectedItem;
            }
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

            string results = "";
            // From USD.
            if (comboFromUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.27269);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.82752);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 73.1120);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.73551);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 103.86);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.89);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 24.00);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000027);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}$ in US Dollars (USD) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00079);
                    return;
                }
            }

            // From CAD
            if (comboFromCAD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.78514);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.64972);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 57.4029);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.57747);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 81.54);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.7);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 18.85);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000021);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}$ in Canadian Dollars (CAD) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00062);
                    return;
                }
            }

            // From EUR
            if (comboFromEUR.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1.20748);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.53675);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 88.2813);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.88812);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 125.37);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 1.08);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 29.01);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000033);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}€ in Euros (EUR) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00096);
                    return;
                }
            }

            // From INR
            if (comboFromINR.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.01363);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 0.01735);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.01128);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.01003);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 1.42);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.012);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 0.33);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.0000011);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}₹ in Indian Rupees (INR) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.000011);
                    return;
                }
            }

            // From GBP
            if (comboFromGBP.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1.35818);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.72854);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 1.12418);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 99.2990);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 141.08);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 1.21);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 32.63);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000037);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}£ in British Pounds (GBP) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.0011);
                    return;
                }
            }

            // From JPY
            if (comboFromJPY.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.00963);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 0.01225);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.00797);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 0.70376);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.00708);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.0086);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 0.23);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.0000010);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}¥ in Japanese Yen (JPY) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.0000076);
                    return;
                }
            }

            //CHF
            if (comboFromCHF.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1.12);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1.43);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.93);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 82.16);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.83);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 116.50);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 26.95);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.000031);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}CHF in Swiss Francs (CHF) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.00088);
                    return;
                }
            }

            //CUP
            if (comboFromCUP.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 0.042);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 0.053);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 0.034);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 3.05);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 0.031);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 4.32);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 0.037);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.0000011);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}₱ in Cuban Pesos (CUP) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 0.000032);
                    return;
                }
            }

            //BTC-USD
            if (comboFromBTCUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 36815.70);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 46867.67);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 30443.82);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 2694725.16);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 27224.34);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 3844752.60);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 32998.92);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 889318.56);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}₿ in Bitcoin (BTC) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency * 28.37);
                    return;
                }
            }

            //ETH
            if (comboFromETHUSD.IsSelected == true)
            {
                if (comboToUSD.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}$ in US Dollars (USD)",
                        txtAmount.Text, currency * 1402.83);
                    return;
                }
                if (comboToCAD.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}$ in Canadian Dollars (CAD)",
                        txtAmount.Text, currency * 1788.88);
                    return;
                }
                if (comboToEUR.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}€ in Euros (EUR)",
                        txtAmount.Text, currency * 1157.69);
                    return;
                }
                if (comboToINR.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}₹ in Indian Rupees (INR)",
                        txtAmount.Text, currency * 102752.54);
                    return;
                }
                if (comboToGBP.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}£ in British Pounds (GBP)",
                        txtAmount.Text, currency * 1031.20);
                    return;
                }
                if (comboToJPY.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}¥ in Japanese Yen (JPY)",
                        txtAmount.Text, currency * 146014.59);
                    return;
                }
                if (comboToCHF.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}CHF in Swiss Francs (CHF)",
                        txtAmount.Text, currency * 1246.96);
                    return;
                }
                if (comboToCUP.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}₱ in Cuban Pesos (CUP)",
                        txtAmount.Text, currency * 33709.68);
                    return;
                }
                if (comboToBTCUSD.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}₿ in Bitcoin (BTC)",
                        txtAmount.Text, currency * 0.038);
                    return;
                }
                if (comboToETHUSD.IsSelected == true)
                {
                    results = string.Format("{0}Ξ in Ethereum (ETH) has been converted to {1:n2}Ξ in Ethereum (ETH)",
                        txtAmount.Text, currency);
                    return;
                }
            }

            string timestamp = string.Format("{0}", DateTime.Now);

            Conversion conversion = new Conversion(results, timestamp);
            convertList.Add(conversion);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Conversion conversion in convertList)
                {
                    writer.WriteLine(conversion.ToDataString());
                }
            }
        }
    }
}