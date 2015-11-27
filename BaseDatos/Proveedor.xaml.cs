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
    /// Interaction logic for Tiempo.xaml
    /// </summary>
    public partial class Tiempo : Window
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            BaseDatos.BD.Tiempo ti = new BaseDatos.BD.Tiempo();

            ti.NumeroDeEntrega = txt1.Text;
            ti.NombreProveedor = txt2.Text;
            db.Tiempos.Add(ti);
            db.SaveChanges();
            MessageBox.Show("Datos Fueron Guardados Correctamente");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EdTiempo Ventana = new EdTiempo();
            Ventana.Show();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = Convert.ToInt32(txt1.Text);

            var temp = db.Tiempos.SingleOrDefault(s => s.IDTiempo == id);

            if (temp != null)
            {
                db.Tiempos.Remove(temp);
                db.SaveChanges();
            }
        }
    }
}
