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

namespace Opgave_3._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnDraw.Click += BtnDraw_Click;
        }

        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            Line l1 = new Line();
            l1.X1 = 100; l1.Y1 = 0;
            l1.X2 = 100; l1.Y2 = 300;
            l1.Stroke = new SolidColorBrush(Colors.Black);

            Line l2 = new Line();
            l2.X1 = 200; l2.Y1 = 0;
            l2.X2 = 200; l2.Y2 = 300;
            l2.Stroke = new SolidColorBrush(Colors.Black);

            Line l3 = new Line();
            l3.X1 = 0; l3.Y1 = 100;
            l3.X2 = 300; l3.Y2 = 100;
            l3.Stroke = new SolidColorBrush(Colors.Black);

            Line l4 = new Line();
            l4.X1 = 0; l4.Y1 = 200;
            l4.X2 = 300; l4.Y2 = 200;
            l4.Stroke = new SolidColorBrush(Colors.Black);

            paperCanvas.Children.Add(l1);
            paperCanvas.Children.Add(l2);
            paperCanvas.Children.Add(l3);
            paperCanvas.Children.Add(l4);
        }
    }
}
