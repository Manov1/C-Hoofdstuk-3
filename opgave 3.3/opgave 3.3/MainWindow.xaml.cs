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

namespace opgave_3._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnHouse.Click += BtnHouse_Click;
        }

        private void BtnHouse_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rec1 = new Rectangle();
            rec1.Width = 250;
            rec1.Height = 125;
            rec1.Margin = new Thickness(100, 150, 0, 0);
            rec1.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle rec2 = new Rectangle();
            rec2.Width = 50;
            rec2.Height = 100;
            rec2.Margin = new Thickness(200, 175, 0, 0);
            rec2.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle rec3 = new Rectangle();
            rec3.Width = 50;
            rec3.Height = 50;
            rec3.Margin = new Thickness(275, 175, 0, 0);
            rec3.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle rec4 = new Rectangle();
            rec4.Width = 50;
            rec4.Height = 50;
            rec4.Margin = new Thickness(125, 175, 0, 0);
            rec4.Stroke = new SolidColorBrush(Colors.Black);

            Line ln1 = new Line();
            ln1.X1 = 100; ln1.Y1 = 150;
            ln1.X2 = 225; ln1.Y2 = 60;
            ln1.Stroke = new SolidColorBrush(Colors.Black);

            Line ln2 = new Line();
            ln2.X1 = 350; ln2.Y1 = 150;
            ln2.X2 = 225; ln2.Y2 = 60;
            ln2.Stroke = new SolidColorBrush(Colors.Black);

            paperCanvas.Children.Add(rec1);
            paperCanvas.Children.Add(rec2);
            paperCanvas.Children.Add(rec3);
            paperCanvas.Children.Add(rec4);
            paperCanvas.Children.Add(ln1);
            paperCanvas.Children.Add(ln2);
        }
    }
}
