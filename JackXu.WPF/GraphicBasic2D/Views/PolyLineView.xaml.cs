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

namespace JackXu.WPF.GraphicBasic2D.Views
{
    /// <summary>
    /// Interaction logic for PolyLineView.xaml
    /// </summary>
    public partial class PolyLineView : UserControl
    {
        public PolyLineView()
        {
            InitializeComponent();

            for (int i = 0; i < 70; i++)
            {
                double x = i * Math.PI;
                double y = 40 + 30 * Math.Sin(x / 10);
                Polyline1.Points.Add(new Point(x, y));
            }
        }
    }
}
