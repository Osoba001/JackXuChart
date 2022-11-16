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
    /// Interaction logic for Chart2DResizableCanvasView.xaml
    /// </summary>
    public partial class Chart2DResizableCanvasView : UserControl
    {
        private double xMin = 0.0;
        private double xMax = 0.0;
        private double yMin = 0.0;
        private double yMax = 0.0;
        private Line? line1;
        private Polyline? polyline1;
        public Chart2DResizableCanvasView()
        {
            InitializeComponent();
        }
        private void AddGraphics()
        {
            ChartCanvas.Children.Clear();
            xMin = Convert.ToDouble(tbXMin.Text);
            xMax = Convert.ToDouble(tbXMax.Text);
            yMin = Convert.ToDouble(tbYMin.Text);
            yMax = Convert.ToDouble(tbYMax.Text);

            line1 = new Line();
            line1.X1 = XNormalize(2.0);
            line1.Y1 = YNormalize(4.0);
            line1.X2 = XNormalize(8.0);
            line1.Y2 = YNormalize(10.0);
            line1.Stroke = Brushes.Blue;
            line1.StrokeThickness = 2;
            ChartCanvas.Children.Add(line1);

            polyline1 = new Polyline();
            polyline1.Points.Add(new Point(XNormalize(8), YNormalize(8)));
            polyline1.Points.Add(new Point(XNormalize(6), YNormalize(6)));
            polyline1.Points.Add(new Point(XNormalize(6), YNormalize(4)));
            polyline1.Points.Add(new Point(XNormalize(4), YNormalize(4)));
            polyline1.Points.Add(new Point(XNormalize(4), YNormalize(6)));
            polyline1.Points.Add(new Point(XNormalize(6), YNormalize(6)));
            polyline1.Stroke = Brushes.Red;
            polyline1.StrokeThickness = 5;
            ChartCanvas.Children.Add(polyline1);

        }

        private double XNormalize(double x)
        {
            return (x - xMin) * ChartCanvas.Width / (xMax - xMin);
        }

        public double YNormalize(double y)
        {
            return ChartCanvas.Height - (y - yMin) * ChartCanvas.Height / (yMax - yMin);
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            
            AddGraphics();
        }
        private void chartGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChartCanvas.Width = chartGrid.ActualWidth
                - chartBorder.Margin.Left
                - chartBorder.Margin.Right
                - chartBorder.BorderThickness.Left
                - chartBorder.BorderThickness.Right;

            ChartCanvas.Height = chartGrid.ActualHeight
                - chartBorder.Margin.Top
                - chartBorder.Margin.Bottom
                - chartBorder.BorderThickness.Bottom
                - chartBorder.BorderThickness.Top;
            
        }
    }
}
