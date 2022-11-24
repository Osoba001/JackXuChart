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
    /// Interaction logic for HitTestingView.xaml
    /// </summary>
    public partial class HitTestingView : UserControl
    {
        private List<Rectangle> hitList= new();
        private EllipseGeometry hitArea = new();
        public HitTestingView()
        {
            InitializeComponent();
            Onitialize();
        }

        private void Onitialize()
        {
            foreach (Rectangle rect in canvas1.Children)
            {
                rect.Fill = Brushes.LightBlue;
            }
        }
        private void OnMounseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Onitialize();

            //Get Mouse click point
            Point pt= e.GetPosition(canvas1);

            //Define hit-testing Area
            hitArea = new EllipseGeometry(pt, 1.0, 1.0);
            hitList.Clear();

            //Call HitTest Method
            VisualTreeHelper.HitTest(canvas1, null, new HitTestResultCallback(HitTestCallBack),
                new GeometryHitTestParameters(hitArea));
            if (hitList.Count>0)
            {
                foreach (Rectangle rect in hitList)
                {
                    rect.Fill = Brushes.LightCoral;
                }
                MessageBox.Show("You hit " + hitList.Count.ToString() + " rectangle");
            }
        }

        public HitTestResultBehavior HitTestCallBack( HitTestResult result)
        {
            //Retrieve the result of the hit test
            IntersectionDetail intersectionDetail=((GeometryHitTestResult)result).IntersectionDetail;

            switch (intersectionDetail)
            {
                case IntersectionDetail.FullyContains:
                    hitList.Add((Rectangle)result.VisualHit);
                    return HitTestResultBehavior.Continue;

                case IntersectionDetail.Intersects:
                    return HitTestResultBehavior.Continue;
                
                case IntersectionDetail.FullyInside:
                    return HitTestResultBehavior.Continue;
                
                default:
                    return HitTestResultBehavior.Stop;
            }
        }
    }
}
