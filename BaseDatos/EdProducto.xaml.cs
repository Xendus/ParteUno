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
    /// Interaction logic for EdProducto.xaml
    /// </summary>
    public partial class EdProducto : Window
    {
        public EdProducto()
        {
            InitializeComponent();
        }

        private void DProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            if (DProducto.SelectedValue != null)
            {
                int id = (int)DProducto.SelectedValue;
                var temp = from s in db.Productoss
                           where s.IDCodigo == id
                           select s;
                DeProducto.ItemsSource = temp.ToList();
            }
        }

        private void DeProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            DProducto.ItemsSource = db.Tiempos.ToList();
            DProducto.DisplayMemberPath = "IDCodigo";
            DProducto.SelectedValuePath = "IDCodigo";
            DProducto.SelectedIndex = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = Convert.ToInt32(DProducto.SelectedValue);

            var temp = db.Productoss.SingleOrDefault(s => s.IDCodigo == id);

            if (temp != null)
            {
                db.Productoss.Remove(temp);
                db.SaveChanges();
                MessageBox.Show("Datos Fueron Eliminados Correctamente");
                DProducto.ItemsSource = db.Tiempos.ToList();
                DProducto.DisplayMemberPath = "IDCodigo";
                DProducto.SelectedValuePath = "IDCodigo";
                DProducto.SelectedIndex = 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = (Int32)DProducto.SelectedValue;

            var temp = db.Productoss.SingleOrDefault(s => s.IDCodigo == id);


            if (temp != null)
            {
                temp.NombreP = (String)txt1.Text;
                temp.NombreCa = (String)txt2.Text;
                temp.Precio= Convert.ToInt32(txt3.Text);
                db.SaveChanges();
                MessageBox.Show("Datos Fueron Actualizado Correctamente");
            }
        }

        private void DProducto_Loaded(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            DProducto.ItemsSource = db.Productoss.ToList();
                DProducto.DisplayMemberPath = "IDCodigo";
                DProducto.SelectedValuePath = "IDCodigo";
                DProducto.SelectedIndex = 0;
            
        }

        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
