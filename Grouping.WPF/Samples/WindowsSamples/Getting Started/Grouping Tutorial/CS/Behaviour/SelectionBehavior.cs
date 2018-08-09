﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Controls.Primitives;

namespace GroupingTutorial
{
    internal class SelectionBehavior : Behavior<Selector>
    {
        private ViewModel viewModel;

        protected override void OnAttached()
        {
            base.OnAttached();
            this.viewModel = (AssociatedObject.DataContext as ViewModel);
            AssociatedObject.SelectionChanged += OnSelectionChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.SelectionChanged -= OnSelectionChanged;
        }

        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(SelectionBehavior),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedItemChanged));

        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public static readonly DependencyProperty IgnoreNullSelectionProperty =
            DependencyProperty.Register("IgnoreNullSelection", typeof(bool), typeof(SelectionBehavior), new PropertyMetadata(true));

        /// <summary>
        /// Determines whether null selection (which usually occurs since the combobox is rebuilt or its list is refreshed) should be ignored.
        /// True by default.
        /// </summary>
        public bool IgnoreNullSelection
        {
            get { return (bool)GetValue(IgnoreNullSelectionProperty); }
            set { SetValue(IgnoreNullSelectionProperty, value); }
        }

        /// <summary>
        /// Called when the SelectedItem dependency property is changed.
        /// Updates the associated selector's SelectedItem with the new value.
        /// </summary>
        private static void OnSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = (SelectionBehavior)d;
            var selector = behavior.AssociatedObject;
            selector.SelectedValue = e.NewValue;
        }

        /// <summary>
        /// Called when the associated selector's selection is changed.
        /// Tries to assign it to the <see cref="SelectedItem"/> property.
        /// If it fails, updates the selector's with  <see cref="SelectedItem"/> property's current value.
        /// </summary>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IgnoreNullSelection && (e.AddedItems == null || e.AddedItems.Count == 0)) return;
            SelectedItem = AssociatedObject.SelectedItem;

            if (SelectedItem != AssociatedObject.SelectedItem)
            {
                AssociatedObject.SelectedItem = SelectedItem;
            }
            if (this.AssociatedObject.Name.Equals("summaryType"))
            {
                this.viewModel.SelectedIndexVal = (sender as ComboBox).SelectedIndex;
                this.viewModel.MappingName = (AssociatedObject.SelectedItem as Data).SummaryMapping;
            }           
        }
    }
}
