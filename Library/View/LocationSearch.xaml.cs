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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.View
{
    /// <summary>
    /// Логика взаимодействия для LocationSearch.xaml
    /// </summary>
    public partial class LocationSearch : UserControl
    {
        public LocationSearch()
        {
            InitializeComponent();
        }
        private void DigitInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0) == false)
            {
                e.Handled = true;
            }
        }
    }
}
