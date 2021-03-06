﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Currency_Converter
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
            // Button to convert currency.
            CurrencyConvert();
        }

        private void txtAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Enter currency amount to be converted.
            CurrencyConvert();
        }

        private void CurrencyConvert()
        {
            double currency;
            if (!double.TryParse(txtAmount.Text, out currency))
            {
                return;
            }
            
            
        }
    }
}
