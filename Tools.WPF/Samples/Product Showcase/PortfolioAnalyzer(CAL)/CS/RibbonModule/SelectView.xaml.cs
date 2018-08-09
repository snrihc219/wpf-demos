﻿using System.Windows.Controls;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Composite.Modularity;
using System.Windows.Input;
using Microsoft.Practices.Composite.Events;
using PortfolioAnalyzer.Infrastructure;
using System.Windows;
using Syncfusion.Windows.Tools.Controls;
using Syncfusion.Windows.Shared;

namespace PortfolioAnalyzer.RibbonModule
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class SelectView
    {
        IEventAggregator eventAggregator;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectView"/> class.
        /// </summary>
        /// <param name="eventAgg">The event agg.</param>
        /// <param name="viewModel">The view model.</param>
        public SelectView(IEventAggregator eventAgg, AppMenuViewModel viewModel)
        {
            this.eventAggregator = eventAgg;
            InitializeComponent();
            this.DataContext = viewModel;
        }       
    
    }
}
