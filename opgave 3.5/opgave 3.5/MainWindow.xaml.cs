using System;
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

namespace opgave_3._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 10; i >= 0; i--)
            {
                var e = new Ellipse()
                {
                    Height = i * 20,
                    Width = i * 20,
                    Margin = new Thickness(200, 200, 0, 0),
                    Fill = new SolidColorBrush(i % 2 == 0 ? Colors.Red : Colors.White)
                };
                grid.Children.Add(e);
            }

        }
    }
}
