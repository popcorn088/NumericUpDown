using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// ユーザー コントロールの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234236 を参照してください

namespace NumericUpDown.UserControls
{
    public sealed partial class NumericUpDown : UserControl
    {
        /*
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(NumericUpDown), new PropertyMetadata(0, ValueChanged));
        public double Value
        {
            get
            {
                return (double)GetValue(ValueProperty); 
            }
            set 
            {
                SetValue(ValueProperty, value); 
            }
        }
        private static void ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }*/

        public NumericUpDown()
        {
            this.InitializeComponent();
        }
    }
}
