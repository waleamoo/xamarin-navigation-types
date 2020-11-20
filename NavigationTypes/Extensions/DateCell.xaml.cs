using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationTypes.Extensions
{
    public partial class DateCell : ViewCell
    {
        public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(DateCell));
        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }

            set
            {
                SetValue(LabelProperty, value); 
            }

        } // Makes the label property changeable 
        public DateCell()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
