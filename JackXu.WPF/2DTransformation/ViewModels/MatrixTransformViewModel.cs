using JackXu.WPF.Main.Commands;
using JackXu.WPF.Main.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace JackXu.WPF._2DTransformation.ViewModels
{
    public class MatrixTransformViewModel:ViewModelBase
    {
        Matrix matrix;
        CustomMatrix customMatrix;
        public MatrixTransformViewModel()
        {
            
            
            ScaleCommand = new DelegateCommand(ScaleMatrix, CanExecuteScaleMatrix);
            TranslateCommand = new DelegateCommand(TranslateMatrix, CanExecuteTranslateMatrix);
            RotateCommand = new DelegateCommand(RotateMatrix, CanExecuteRotateMatrix);
            RotateAtCommand = new DelegateCommand(RotateMatrixAt, CanExecuteRotateMatrixAt);
            SkewCommand=new DelegateCommand(SkewMatrix, CanExecuteSkewMatrix);
            _m11 = 1;
            _m21 = 3;
            _m12 = 2;
            _m22 = 4;
            offsetX = 0;
            offsetY = 1;
            Sx = 0.5;
            Sy= 1.5;

        }

        private double _m11;
        public double M11
        {
            get { return _m11; }
            set {
                _m11 = value;
                OnPropertyChanged();
                RotateCommand.RaiseCanExecuteChange();
            }
        }
        
        private double _m21;
        public double M21
        {
            get { return _m21; }
            set { 
                _m21 = value;
                OnPropertyChanged();
                RotateCommand.RaiseCanExecuteChange();
            }
        }
        private double offsetX;
        public double OffsetX
        {
            get { return offsetX; }
            set { 
                offsetX = value;
                OnPropertyChanged();
                RotateCommand.RaiseCanExecuteChange();
            }
        }

        private double _m12;
        public double M12
        {
            get { return _m12; }
            set { 
                _m12 = value;
                OnPropertyChanged();
                RotateCommand.RaiseCanExecuteChange();
            }
        }
        private double _m22;
        public double M22
        {
            get { return _m22; }
            set { 
                _m22 = value;
                OnPropertyChanged();
                RotateCommand.RaiseCanExecuteChange();
            }
        }
        private double offsetY;
        public double OffsetY
        {
            get { return offsetY; }
            set { 
                offsetY = value;
                OnPropertyChanged();
                RotateCommand.RaiseCanExecuteChange();
            }
        }

        #region
        //private double _m13;
        //public double M13
        //{
        //    get { return _m13; }
        //    set { 
        //        _m13 = value;
        //        OnPropertyChanged();
        //    }
        //}
        //private double _m23;
        //public double M23
        //{
        //    get { return _m23; }
        //    set { 
        //        _m23 = value;
        //        OnPropertyChanged();
        //    }
        //}
        //private double _m33;
        //public double M33
        //{
        //    get { return _m33; }
        //    set { 
        //        _m33 = value;
        //        OnPropertyChanged();
        //    }
        //}
        #endregion


        // Scaling 

        private double sx;

        public double Sx
        {
            get { return sx; }
            set { 
                sx = value;
                RotateCommand.RaiseCanExecuteChange();
            }
        }

        private double sy;

        public double Sy
        {
            get { return sy; }
            set {
                sy = value;
                RotateCommand.RaiseCanExecuteChange();
            }
        }


        private void ScaleMatrix()
        {
            //FormMatrix();
            // matrix.Scale(Sx, Sy);
            FormCustomMatric();
           var mat= customMatrix.Scale(sx, sy);
            BindCustomMatrixElementToPpy(mat);

        }

        private void FormMatrix()
        {
            matrix = new Matrix(M11, M12, M21, M22, OffsetX, OffsetY);
        }
        private void FormCustomMatric()
        {
            customMatrix = new CustomMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
        }
        private bool CanExecuteScaleMatrix()
        {
            return true;
        }
        public DelegateCommand ScaleCommand { get; set; }

        //Translate
        private double dx;

        public double Dx
        {
            get { return dx; }
            set { 
                dx = value;
                RotateCommand.RaiseCanExecuteChange();
            }
        }
        private double dy;

        public double Dy
        {
            get { return dy; }
            set {
                dy = value;
                RotateCommand.RaiseCanExecuteChange();
            }
        }
        private void TranslateMatrix()
        {
            FormCustomMatric();
            var mat = customMatrix.Translate(Dx, Dy);
            BindCustomMatrixElementToPpy(mat);

        }
        private bool CanExecuteTranslateMatrix()
        {
            return true;
        }
        public DelegateCommand TranslateCommand { get; set; }


        //Rotate
        private double angle;

        public double Angle
        {
            get {
               
                return angle; 
            }
            set { 
                angle = value;
                RotateCommand.RaiseCanExecuteChange();
            }
        }

        private void RotateMatrix()
        {
            FormCustomMatric();
            var mat = customMatrix.Rotate(Angle);
            BindCustomMatrixElementToPpy(mat);
        }
        private bool CanExecuteRotateMatrix()
        {
            return true;
        }
        public DelegateCommand RotateCommand { get; set; }


        // RotateAt

        private double rotateAtX;

        public double RotateAtX
        {
            get { return rotateAtX; }
            set { 
                rotateAtX = value;
            }
        }
        private double rotateAtY;

        public double RotateAtY
        {
            get { return rotateAtY; }
            set
            {
                rotateAtY = value;
            }
        }
        private void RotateMatrixAt()
        {
            FormCustomMatric();
           var mat= customMatrix.RotateAt(Angle, rotateAtX, rotateAtY);
            BindCustomMatrixElementToPpy(mat);
        }

        private bool CanExecuteRotateMatrixAt()
        {
            return true;
        }

        public DelegateCommand RotateAtCommand { get; set; }


        // Skew
        private double skewX;

        public double SkewX
        {
            get { return skewX; }
            set { 

                skewX = value;
            }
        }

        private double skewY;

        public double SkewY
        {
            get { return skewY; }
            set
            {
                skewY = value;
            }
        }

        private void SkewMatrix()
        {
            FormCustomMatric();
            var mat = customMatrix.Skew(skewX,skewY);
            BindCustomMatrixElementToPpy(mat);
        }

        private bool CanExecuteSkewMatrix()
        {
            return true;
        }

        public DelegateCommand SkewCommand { get; set; }


        //Out put matrix


        private void BindMatrixElementToPpy(Matrix matrix)
        {
            M11r=matrix.M11;
            M12r=matrix.M12;
            M21r=matrix.M21;
            M22r=matrix.M22;
            OffsetXr = matrix.OffsetX;
            OffsetYr=matrix.OffsetY;
        }

        private void BindCustomMatrixElementToPpy(CustomMatrix matrix)
        {
            M11r = matrix.M11;
            M12r = matrix.M12;
            M21r = matrix.M21;
            M22r = matrix.M22;
            OffsetXr = matrix.OffsetX;
            OffsetYr = matrix.OffsetY;
        }

        private double _m11r;
        public double M11r
        {
            get { return _m11r; }
            set
            {
                _m11r = value;
                OnPropertyChanged();
                
            }
        }
        private double _m21r;
        public double M21r
        {
            get { return _m21r; }
            set
            {
                _m21r = value;
                OnPropertyChanged();
            }
        }
        private double offSetXr;
        public double OffsetXr
        {
            get { return offSetXr; }
            set
            {
                offSetXr = value;
                OnPropertyChanged();
            }
        }

        private double _m12r;
        public double M12r
        {
            get { return _m12r; }
            set
            {
                _m12r = value;
                OnPropertyChanged();
            }
        }
        private double _m22r;
        public double M22r
        {
            get { return _m22r; }
            set
            {
                _m22r = value;
                OnPropertyChanged();
            }
        }
        private double offsetYr;
        public double OffsetYr
        {
            get { return offsetYr; }
            set
            {
                offsetYr = value;
                OnPropertyChanged();
            }
        }
    }
}
