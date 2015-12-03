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
using System.Windows.Shapes;

namespace BaseDatos
{
    /// <summary>
    /// Interaction logic for CapturaVentas.xaml
    /// </summary>
    public partial class CapturaVentas : Window
    {
        public CapturaVentas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cliente Ventana = new Cliente();
            Ventana.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Producto Ventana = new Producto();
            Ventana.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Tiempo Ventana = new Tiempo();
            Ventana.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Empleado Ventana = new Empleado();
            Ventana.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow Ventana = new MainWindow();
            Ventana.Show();
        }
    }
}
