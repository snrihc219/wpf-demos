﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Tools.Controls;
using Syncfusion.Windows.Shared;

namespace TabNavigationDemo_2010
{
    /// <summary>
    /// Interaction logic for SkinCombo.xaml
    /// </summary>
    public partial class SkinCombo : UserControl
    {
        public SkinCombo()
        {
            InitializeComponent();
        }

        private void ComboBoxAdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItemAdv item;
            WindowCollection windows = Application.Current.Windows;
            Window samplewindow = windows[0];
            ComboBoxAdv combo = sender as ComboBoxAdv;
            if (combo != null)
            {
                if (combo.SelectedItem != null)
                {
                    item = combo.SelectedItem as ComboBoxItemAdv;
                    SkinStorage.SetVisualStyle(samplewindow, item.Content.ToString());

                }
            }
        }
    }
}
