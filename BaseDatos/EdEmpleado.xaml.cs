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
    /// Interaction logic for EdEmpleado.xaml
    /// </summary>
    public partial class EdEmpleado : Window
    {
        public EdEmpleado()
        {
            InitializeComponent();
        }

        private void DEmpleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
             if (DEmpleado.SelectedValue != null)
            {
            int id = (int)DEmpleado.SelectedValue;
            var temp = from s in db.Empleados
                       where s.IDEmpleado == id
                       select s;
            DeEmpleado.ItemsSource = temp.ToList();
                 }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = Convert.ToInt32(DEmpleado.SelectedValue);

            var temp = db.Empleados.SingleOrDefault(s => s.IDEmpleado == id);

            if (temp != null)
            {
                db.Empleados.Remove(temp);
                db.SaveChanges();
                MessageBox.Show("Datos Fueron Eliminados Correctamente");
                DEmpleado.ItemsSource = db.Tiempos.ToList();
                DEmpleado.DisplayMemberPath = "IDEmpleado";
                DEmpleado.SelectedValuePath = "IDEmpleado";
                DEmpleado.SelectedIndex = 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = (Int32)DEmpleado.SelectedValue;

            var temp = db.Empleados.SingleOrDefault(s => s.IDEmpleado == id);


            if (temp != null)
            {
                temp.NombreE = (String)txt1.Text;
                temp.Contratacion = (String)txt2.Text;
                db.SaveChanges();
                MessageBox.Show("Datos Fueron Actualizado Correctamente");
            }
        }

        private void DeEmpleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            DEmpleado.ItemsSource = db.Empleados.ToList();
            DEmpleado.DisplayMemberPath = "IDEmpleado";
            DEmpleado.SelectedValuePath = "IDEmpleado";
            DEmpleado.SelectedIndex = 0;
        }

        private void DEmpleado_Loaded(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            DEmpleado.ItemsSource = db.Empleados.ToList();
            DEmpleado.DisplayMemberPath = "IDEmpleado";
            DEmpleado.SelectedValuePath = "IDEmpleado";
            DEmpleado.SelectedIndex = 0;
        }
    }
}
