﻿using Syncfusion.UI.Xaml.SmithChart;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Customization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void paletteCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedValue = paletteCombo.SelectedItem.ToString();
            this.SmithChart.ColorModel.Palette = (ColorPalette)Enum.Parse(typeof(ColorPalette), selectedValue, true); 
        }

        private void showDataLabel_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            this.SmithChart.Series[0].DataLabel.ShowLabel = (bool)checkBox.IsChecked;
            this.SmithChart.Series[1].DataLabel.ShowLabel = (bool)checkBox.IsChecked;
        }

        private void showHrzMinorGridLines_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            this.SmithChart.HorizontalAxis.ShowMinorGridlines = (bool)checkBox.IsChecked;
        }
        private void showRdlMinorGridLines_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            this.SmithChart.RadialAxis.ShowMinorGridlines = (bool)checkBox.IsChecked;
        }
    }
}
