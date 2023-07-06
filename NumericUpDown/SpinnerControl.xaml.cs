using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace NumericUpDown
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class SpinnerControl : UserControl
    {
        public static readonly DependencyProperty ValueProperty =
                DependencyProperty.Register(nameof(Value),
                                            typeof(decimal),
                                            typeof(SpinnerControl),
                                            new FrameworkPropertyMetadata(0.0m, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnValueChanged)));

        public decimal Value
        {
            get 
            {
                return (decimal)GetValue(ValueProperty); 
            }
            set
            {
                SetValue(ValueProperty, value); 
            }
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SpinnerControl sc = (SpinnerControl)d;
            if (sc.vm != null)
            {
                sc.vm.Value = (decimal)e.NewValue;
                //sc.textbox.Text = e.NewValue.ToString();
            }
        }

        public static readonly DependencyProperty NickProperty =
                DependencyProperty.Register(nameof(Nick),
                                            typeof(decimal),
                                            typeof(SpinnerControl),
                                            new FrameworkPropertyMetadata(0.0m, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnNickChanged)));

        public decimal Nick
        {
            get
            {
                return (decimal)GetValue(NickProperty);
            }
            set
            {
                SetValue(NickProperty, value);
            }
        }

        private static void OnNickChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SpinnerControl sc = (SpinnerControl)d;
            if (sc.vm != null)
            {
                sc.vm.Nick = (decimal)e.NewValue;
            }
        }

        public static readonly DependencyProperty MinimumProperty =
                DependencyProperty.Register(nameof(Minimum),
                                            typeof(decimal),
                                            typeof(SpinnerControl),
                                            new FrameworkPropertyMetadata(0.0m, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnMinimumChanged)));

        public decimal Minimum
        {
            get
            {
                return (decimal)GetValue(MinimumProperty);
            }
            set
            {
                SetValue(MinimumProperty, value);
            }
        }

        private static void OnMinimumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SpinnerControl sc = (SpinnerControl)d;
            if (sc.vm != null)
            {
                sc.vm.Minimum = (decimal)e.NewValue;
            }
        }

        public static readonly DependencyProperty MaximumProperty =
                DependencyProperty.Register(nameof(Maximum),
                                            typeof(decimal),
                                            typeof(SpinnerControl),
                                            new FrameworkPropertyMetadata(0.0m, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnMaximumChanged)));

        public decimal Maximum
        {
            get
            {
                return (decimal)GetValue(MaximumProperty);
            }
            set
            {
                SetValue(MaximumProperty, value);
            }
        }

        private static void OnMaximumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SpinnerControl sc = (SpinnerControl)d;
            if (sc.vm != null)
            {
                sc.vm.Maximum = (decimal)e.NewValue;
            }
        }

        SpinnerControlViewModel vm = new SpinnerControlViewModel();

        public SpinnerControl()
        {
            InitializeComponent();

            vm.PropertyChanged += Vm_PropertyChanged;
            this.DataContext = vm;
            baseContainer.DataContext = this;
            up_repeat_button.DataContext = vm;
            down_repeat_button.DataContext = vm;

            textbox.SetBinding(
                TextBox.TextProperty,
                new Binding(nameof(Value))
                {
                    Source = this
                }); ;
        }

        private void Vm_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Value)) 
            {
                Value = vm.Value;
            }
        }
    }
}