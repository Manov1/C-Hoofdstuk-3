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

namespace opgave_3._6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            Ellipse el1 = new Ellipse();
            el1.Width = 100;
            el1.Height = 100;
            el1.Margin = new Thickness(0, 0, 0, 0);
            el1.Stroke = new SolidColorBrush(Colors.Black);

            Ellipse el2 = new Ellipse();
            el2.Width = 10;
            el2.Height = 15;
            el2.Margin = new Thickness(0, 0, 35, 30);
            el2.Stroke = new SolidColorBrush(Colors.Black);

            Ellipse el3 = new Ellipse();
            el3.Width = 10;
            el3.Height = 15;
            el3.Margin = new Thickness(35, 0, 0, 30);
            el3.Stroke = new SolidColorBrush(Colors.Black);

            Ellipse el4 = new Ellipse();
            el4.Width = 50;
            el4.Height = 45;
            el4.Margin = new Thickness(0, 5, 0, 0);
            el4.Stroke = new SolidColorBrush(Colors.Black);

            Ellipse el5 = new Ellipse();
            el5.Width = 50;
            el5.Height = 45;
            el5.Margin = new Thickness(30, 5, 0, 30);
            el5.Stroke = new SolidColorBrush(Colors.White);
            el5.Fill = new SolidColorBrush(Colors.White);

            Ellipse el6 = new Ellipse();
            el6.Width = 50;
            el6.Height = 45;
            el6.Margin = new Thickness(0, 5, 30, 30);
            el6.Stroke = new SolidColorBrush(Colors.White);
            el6.Fill = new SolidColorBrush(Colors.White);

            grid.Children.Add(el4);
            grid.Children.Add(el5);
            grid.Children.Add(el6);
            grid.Children.Add(el1);
            grid.Children.Add(el2);
            grid.Children.Add(el3);
        }
    }
}
