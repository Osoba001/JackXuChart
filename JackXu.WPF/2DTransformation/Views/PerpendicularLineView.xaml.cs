﻿using System;
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
    /// Interaction logic for PerpendicularLineView.xaml
    /// </summary>
    public partial class PerpendicularLineView : UserControl
    {
        private Line line1;
        private Line line2;
        public PerpendicularLineView()
        {
            InitializeComponent();
            Rectangle rect=new Rectangle();
            rect.Width = canvas1.Width;
            rect.Height = canvas1.Height;
            rect.Stroke = Brushes.Black;
            canvas1.Children.Add(rect);
            line1 = new Line();
            line2 = new Line();
            AddLines();
        }
        private void AddLines()
        {
            Point pt1=new Point();
            Point pt2=new Point();

            pt1.X = double.Parse(tbX1.Text);
            pt1.Y = double.Parse(tbY1.Text);
            pt2.X = double.Parse(tbX2.Text);
            pt2.Y = double.Parse(tbY2.Text);
            double length=0.5*double.Parse(tbLength.Text);

            line1=new Line();
            line1.X1 = pt1.X;
            line1.Y1 = pt1.Y;
            line1.X2 = pt2.X;
            line1.Y2 = pt2.Y;

            line1.Stroke = Brushes.Gray;
            line1.StrokeThickness = 4;
            canvas1.Children.Add(line1);
            Canvas.SetLeft(tbPoint1,pt1.X);
            Canvas.SetTop(tbPoint1,pt1.Y);
            Canvas.SetLeft(tbPoint2,pt2.X);
            Canvas.SetTop (tbPoint2,pt2.Y);
            tbPoint1.Text = "Pt1(" + pt1.ToString() + ")";
            tbPoint2.Text="Pt2("+pt2.ToString() + ")";

            Vector v1=pt1 - pt2;
            Matrix m1=new Matrix();
            Point pt3=new Point();
            Point pt4=new Point();
            m1.Rotate(-90);
            v1.Normalize();
            v1 *= length;

            line2 =new Line();
            line2.Stroke= Brushes.Gray;
            line2.StrokeThickness = 4;
            line2.StrokeDashArray = DoubleCollection.Parse("3,1");

            pt3 = pt2 + v1 * m1;
            m1= new Matrix();
            m1.Rotate(90);
            pt4=pt2+ v1 * m1;
            line2.X1 = pt3.X;
            line2.Y1 = pt3.Y;
            line2.X2 = pt4.X;
            line2.Y2 = pt4.Y;
            canvas1.Children.Add(line2);

            Canvas.SetLeft(tbPoint3,pt3.X);
            Canvas.SetTop(tbPoint3,pt3.Y);
            Canvas.SetLeft(tbPoint4 ,pt4.X);
            Canvas.SetTop(tbPoint4 , pt4.Y);

            pt3.X=Math.Round(pt3.X,1);
            pt3.Y=Math.Round(pt3.Y,1);
            pt4.X=Math.Round(pt4.X,1);
            pt4.Y=Math.Round(pt4.Y,1);

            tbPoint3.Text = "Pt3(" + pt3.ToString() + ")";
            tbPoint4.Text = "Pt4(" + pt4.ToString() + ")";
            
        }

        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            if(line1!=null)
                canvas1.Children.Remove(line1);
            if(line2!=null)
                canvas1.Children.Remove(line2);
            AddLines();
        }
    }
}
