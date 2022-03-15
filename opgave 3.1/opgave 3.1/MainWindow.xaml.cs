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

namespace opgave_3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Btn1.Click += Btn1_Click;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Line l1 = new Line();
            l1.X1 = 20; l1.Y1 = 280;
            l1.X2 = 140; l1.Y2 = 10;
            l1.Stroke = new SolidColorBrush(Colors.Black);

            Line l2 = new Line();
            l2.X1 = 140; l2.Y1 = 10;
            l2.X2 = 280; l2.Y2 = 280;
            l2.Stroke = new SolidColorBrush(Colors.Black);

            Line l3 = new Line();
            l3.X1 = 280; l3.Y1 = 280;
            l3.X2 = 20; l3.Y2 = 280;
            l3.Stroke = new SolidColorBrush(Colors.Black);

            paperCanvas.Children.Add(l1);
            paperCanvas.Children.Add(l2);
            paperCanvas.Children.Add(l3);
        }
    }
}
