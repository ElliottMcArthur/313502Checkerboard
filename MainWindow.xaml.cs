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

namespace Drawing_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++) 
                { 
                    Rectangle a = new Rectangle();
                    a.Height = 100;
                    a.Width = 100;
                    if ((j + i) % 2 == 0)
                    {
                        a.Fill = Brushes.Aqua;
                    }

                    else
                    {
                        a.Fill = Brushes.DarkRed;
                    }

                    Canvas.Children.Add(a);
                    Canvas.SetLeft(a, i * 100);
                    Canvas.SetTop(a, j * 100);
                }
            }
        }
    }
}
