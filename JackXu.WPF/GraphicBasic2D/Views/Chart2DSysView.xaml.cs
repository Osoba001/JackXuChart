using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace JackXu.WPF.GraphicBasic2D.Views
{
    /// <summary>
    /// Interaction logic for Chart2DSysView.xaml
    /// </summary>
    public partial class Chart2DSysView : UserControl
    {
        private double xMin = 0.0;
        private double xMax = 0.0;
        private double yMin = 0.0;
        private double yMax = 0.0;
        private Line? line1;
        private Polyline? polyline1;
        public Chart2DSysView()
        {
            InitializeComponent();
        }
       
        private void AddGraphics()
        {
            line1 = new Line();
            line1.X1 = XNormalize(2.0);
            line1.Y1 = YNormalize(4.0);
            line1.X2 = XNormalize(8.0);
            line1.Y2 = YNormalize(10.0);
            line1.Stroke = Brushes.Blue;
            line1.StrokeThickness = 2;
            chartCanvas.Children.Add(line1);

            polyline1 = new Polyline();
            polyline1.Points.Add(new Point(XNormalize(8), YNormalize(8)));
            polyline1.Points.Add(new Point(XNormalize(6), YNormalize(6)));
            polyline1.Points.Add(new Point(XNormalize(6), YNormalize(4)));
            polyline1.Points.Add(new Point(XNormalize(4), YNormalize(4)));
            polyline1.Points.Add(new Point(XNormalize(4), YNormalize(6)));
            polyline1.Points.Add(new Point(XNormalize(6), YNormalize(6)));
            polyline1.Stroke = Brushes.Red;
            polyline1.StrokeThickness = 5;
            chartCanvas.Children.Add(polyline1);

        }
       
        private double XNormalize(double x)
        {
            return (x - xMin)*chartCanvas.Width / (xMax - xMin);
        }

        public double YNormalize(double y)
        {
            return chartCanvas.Height-(y - yMin)*chartCanvas.Height / (yMax - yMin);
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            chartCanvas.Children.Clear();
            xMin = Convert.ToDouble(tbXMin.Text);
            xMax =Convert.ToDouble(tbXMax.Text);
            yMin = Convert.ToDouble(tbYMin.Text);
            yMax = Convert.ToDouble(tbYMax.Text);
            AddGraphics();
        }
    }
}
