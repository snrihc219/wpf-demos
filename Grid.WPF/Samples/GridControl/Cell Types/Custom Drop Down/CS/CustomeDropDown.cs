﻿namespace CustomDD_2008
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using Syncfusion.Windows.Controls.Grid;

   public class CustomeDropDown : GridCellDropDownControlBase
    {
        public ImageTextListBox ListBoxPart
        {
            get
            {
                if (this.PopupContent != null)
                {
                    return this.PopupContent.Content as ImageTextListBox;
                }

                return null;
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        protected override void OnContentLoaded(ContentControl popupContent)
        {
            ImageTextListBox l = new ImageTextListBox(this);
            l.Height = 200;
            popupContent.Content = l;

            // this will wire the events in the base implementation
            base.OnContentLoaded(popupContent);
        }
    }
}
