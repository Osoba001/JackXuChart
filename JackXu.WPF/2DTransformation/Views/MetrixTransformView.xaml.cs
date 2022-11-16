using JackXu.WPF._2DTransformation.ViewModels;
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

namespace JackXu.WPF._2DTransformation.Views
{
    /// <summary>
    /// Interaction logic for MetrixTransformView.xaml
    /// </summary>
    public partial class MetrixTransformView : UserControl
    {

        //public List<Double> MatrixElements;
        public MetrixTransformView()
        {
            InitializeComponent();

            DataContext = new MatrixTransformViewModel();

        }
        //private Matrix MatrixRound(Matrix m)
        //{
        //    m.M11 = Math.Round(m.M11, 3);
        //    m.M12 = Math.Round(m.M12, 3);
        //    m.M21 = Math.Round(m.M21, 3);
        //    m.M22 = Math.Round(m.M22, 3);
        //    m.OffsetX = Math.Round(m.OffsetX, 3);
        //    m.OffsetY = Math.Round(m.OffsetY, 3);
        //    return m;
        //}

        //private Matrix ListToMatrix(List<double> list)
        //{
        //    return new Matrix(
        //        list.ElementAt(0),
        //        list.ElementAt(1),
        //        list.ElementAt(2),
        //        list.ElementAt(3),
        //        list.ElementAt(4),
        //        list.ElementAt(5)
        //        );
        //}

        //private Matrix ScaleMatrix(Matrix matrix, double sx, double sy)
        //{
        //     matrix.Scale(sx, sy);
        //    return matrix;
        //}

        //private Matrix TranslateMatrix(Matrix matrix, double dx, double dy)
        //{
        //    matrix.Translate(dx, dy);
        //    return matrix;
        //}

        //private Matrix RotateMatrix(Matrix matrix, double angle)
        //{
        //   matrix.Rotate(angle);
        //    return matrix;
        //}

        //private Matrix RotateMatrixAt(Matrix matrix, double angle, double x, Double y)
        //{
        //    matrix.RotateAt(angle, x, y);
        //    return matrix;
        //}

        //public Matrix SkewMatrix(Matrix matrix)
        //{
        //    matrix.Skew(45, 30);
        //    return matrix;
        //}

        //private void btnScale_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
