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
    /// Interaction logic for Producto.xaml
    /// </summary>
    public partial class Producto : Window
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            BaseDatos.BD.Producto pro= new BaseDatos.BD.Producto();

            pro.NombreP = txt1.Text;
            pro.NombreCa = txt2.Text;
            pro.Precio = Convert.ToInt32(txt3.Text);
            db.Productos.Add(pro);
            db.SaveChanges();
            MessageBox.Show("Datos Fueron Guardados Correctamente");
        }
    }
}
