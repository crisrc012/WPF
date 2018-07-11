using System;
using System.Globalization;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using cls_BLL.Controles;
using cls_DAL.Controles;

namespace wpf_Ecuaciones_PL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void txt_NumA_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            CultureInfo cultura = CultureInfo.CurrentCulture;
            var FormatoNumero = cultura.NumberFormat;
            string sSepDecimal = FormatoNumero.NumberDecimalSeparator.ToString().Trim();
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || 
                e.Key.Equals(Key.Subtract) || e.Key.Equals(sSepDecimal))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (txt_NumA.Text == "" || txt_NumB.Text == "" || txt_NumC.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Es necesario indicar todos los valores",
                    "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cls_Ecuaciones_DAL ObjEcuDal = new cls_Ecuaciones_DAL();
                cls_Ecuaciones_BLL ObjEcuBLL = new cls_Ecuaciones_BLL();
                ObjEcuDal.fNumA = Convert.ToSingle(txt_NumA.Text);
                ObjEcuDal.fNumB = Convert.ToSingle(txt_NumB.Text);
                ObjEcuDal.fNumC = Convert.ToSingle(txt_NumC.Text);
                ObjEcuBLL.Discriminante(ref ObjEcuDal);
                txt_Resultado.Text = Convert.ToString(Math.Round((ObjEcuDal.fDiscriminante), 2));
                if (ObjEcuDal.fDiscriminante < 0)
                {
                    System.Windows.Forms.MessageBox.Show("La ecuación no tiene solución");
                    txt_Resultado1.Text = "";
                    txt_Resultado2.Text = "";
                }
                else if (ObjEcuDal.fDiscriminante == 0)
                {
                    ObjEcuBLL.Solucion1(ref ObjEcuDal);
                    System.Windows.Forms.MessageBox.Show("La ecuación tiene una solución");
                    txt_Resultado1.Text = Convert.ToString(Math.Round((ObjEcuDal.fResultado1), 2));
                    txt_Resultado2.Text = "";
                }
                else
                {
                    ObjEcuBLL.Solucion2(ref ObjEcuDal);
                    System.Windows.Forms.MessageBox.Show("La ecuación tiene dos soluciones posibles");
                    txt_Resultado1.Text = Convert.ToString(Math.Round((ObjEcuDal.fResultado2a), 2));
                    txt_Resultado2.Text = Convert.ToString(Math.Round((ObjEcuDal.fResultado2b), 2));
                }
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txt_NumA.Text = string.Empty;
            txt_NumB.Text = string.Empty;
            txt_NumC.Text = string.Empty;
            txt_Resultado.Text = string.Empty;
            txt_Resultado1.Text = string.Empty;
            txt_Resultado2.Text = string.Empty;
        }
    }
}
