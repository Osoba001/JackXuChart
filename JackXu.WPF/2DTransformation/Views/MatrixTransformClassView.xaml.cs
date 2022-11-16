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
    /// Interaction logic for MatrixTransformClassView.xaml
    /// </summary>
    public partial class MatrixTransformClassView : UserControl
    {
        public MatrixTransformClassView()
        {
            InitializeComponent();
        }

        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            Matrix m=new Matrix();
            m.M11= double.Parse(tbM11.Text);
            m.M12= double.Parse(tbM12.Text);
            m.M21=double.Parse(tbM21.Text);
            m.M22= double.Parse(tbM22.Text);
            m.OffsetX=double.Parse(tbOffsetX.Text);
            m.OffsetY=double.Parse(tbOffsetY.Text);
            matrixTransform.Matrix = m;
        }
    }
}
