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

namespace opgave_3._4
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

        private void paperCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            Line ln1 = new Line();
            ln1.X1 = 50; ln1.Y1 = 0;
            ln1.X2 = 50; ln1.Y2 = 250;
            ln1.Stroke = new SolidColorBrush(Colors.Black);

            Line ln2 = new Line();
            ln2.X1 = 100; ln2.Y1 = 0;
            ln2.X2 = 100; ln2.Y2 = 250;
            ln2.Stroke = new SolidColorBrush(Colors.Black);

            Line ln3 = new Line();
            ln3.X1 = 150; ln3.Y1 = 0;
            ln3.X2 = 150; ln3.Y2 = 250;
            ln3.Stroke = new SolidColorBrush(Colors.Black);

            Line ln4 = new Line();
            ln4.X1 = 200; ln4.Y1 = 0;
            ln4.X2 = 200; ln4.Y2 = 250;
            ln4.Stroke = new SolidColorBrush(Colors.Black);

            Line ln5 = new Line();
            ln5.X1 = 250; ln5.Y1 = 0;
            ln5.X2 = 250; ln5.Y2 = 250;
            ln5.Stroke = new SolidColorBrush(Colors.Black);

            Line ln6 = new Line();
            ln6.X1 = 300; ln6.Y1 = 0;
            ln6.X2 = 300; ln6.Y2 = 250;
            ln6.Stroke = new SolidColorBrush(Colors.Black);

            Line ln7 = new Line();
            ln7.X1 = 350; ln7.Y1 = 0;
            ln7.X2 = 350; ln7.Y2 = 250;
            ln7.Stroke = new SolidColorBrush(Colors.Black);

            Line ln8 = new Line();
            ln8.X1 = 400; ln8.Y1 = 0;
            ln8.X2 = 400; ln8.Y2 = 250;
            ln8.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle rec1 = new Rectangle();
            rec1.Width = 300;
            rec1.Height = 25;
            rec1.Margin = new Thickness(0, 45, 0, 0);
            rec1.Stroke = new SolidColorBrush(Colors.Black);
            rec1.Fill = new SolidColorBrush(Colors.Blue);

            Rectangle rec2 = new Rectangle();
            rec2.Width = 350;
            rec2.Height = 25;
            rec2.Margin = new Thickness(0, 95, 0, 0);
            rec2.Stroke = new SolidColorBrush(Colors.Black);
            rec2.Fill = new SolidColorBrush(Colors.Blue);

            Rectangle rec3 = new Rectangle();
            rec3.Width = 240;
            rec3.Height = 25;
            rec3.Margin = new Thickness(0, 145, 0, 0);
            rec3.Stroke = new SolidColorBrush(Colors.Black);
            rec3.Fill = new SolidColorBrush(Colors.Blue);

            Rectangle rec4 = new Rectangle();
            rec4.Width = 260;
            rec4.Height = 25;
            rec4.Margin = new Thickness(0, 195, 0, 0);
            rec4.Stroke = new SolidColorBrush(Colors.Black);
            rec4.Fill = new SolidColorBrush(Colors.Blue);

            paperCanvas.Children.Add(ln1);
            paperCanvas.Children.Add(ln2);
            paperCanvas.Children.Add(ln3);
            paperCanvas.Children.Add(ln4);
            paperCanvas.Children.Add(ln5);
            paperCanvas.Children.Add(ln6);
            paperCanvas.Children.Add(ln7);
            paperCanvas.Children.Add(ln8);
            paperCanvas.Children.Add(rec1);
            paperCanvas.Children.Add(rec2);
            paperCanvas.Children.Add(rec3);
            paperCanvas.Children.Add(rec4);
        }
    }
}
