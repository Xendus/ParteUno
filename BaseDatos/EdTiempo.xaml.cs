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
    /// Interaction logic for EdTiempo.xaml
    /// </summary>
    public partial class EdTiempo : Window
    {
        public EdTiempo()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            if (DTiempo.SelectedValue != null)
            {
                int id = (int)DTiempo.SelectedValue;
                //algo
                var cons = from s in db.Tiempos
                           where s.IDTiempo == id
                           select s;
                DeTiempo.ItemsSource = cons.ToList();
            }
            //var cons1 = db.Tiempos.SingleOrDefault(s => s.IDTiempo == id);
            //txt1.Text=cons1.

        }

        private void DeTiempo_Loaded(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            DTiempo.ItemsSource = db.Tiempos.ToList();
            DTiempo.DisplayMemberPath = "IDTiempo";
            DTiempo.SelectedValuePath = "IDTiempo";
            DTiempo.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = (Int32)DTiempo.SelectedValue;

            var cons = db.Tiempos.SingleOrDefault(s => s.IDTiempo == id);


            if (cons != null)
            {
                cons.Dia = (String)txt1.Text;
                cons.Mes = (String)txt2.Text;
                cons.Año = (String)txt3.Text;
                db.SaveChanges();

                MessageBox.Show("Datos Fueron Actualizado Correctamente");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = Convert.ToInt32(DTiempo.SelectedValue);

            var temp = db.Tiempos.SingleOrDefault(s => s.IDTiempo == id);

            if (temp != null)
            {
                db.Tiempos.Remove(temp);
                db.SaveChanges();
                MessageBox.Show("Datos Fueron Eliminados Correctamente");
                DTiempo.ItemsSource = db.Tiempos.ToList();
                DTiempo.DisplayMemberPath = "IDTiempo";
                DTiempo.SelectedValuePath = "IDTiempo";
                DTiempo.SelectedIndex = 0;
            }
           
        }
    }
}

