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
    /// Interaction logic for EdCliente.xaml
    /// </summary>
    public partial class EdCliente : Window
    {
        public EdCliente()
        {
            InitializeComponent();
        }

        private void DCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = (int)DCliente.SelectedValue;
            var temp = from s in db.Clientes
                       where s.IDCliente == id
                       select s;
            DeCliente.ItemsSource = temp.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = Convert.ToInt32(DCliente.SelectedValue);

            var temp = db.Clientes.SingleOrDefault(s => s.IDCliente == id);

            if (temp != null)
            {
                db.Clientes.Remove(temp);
                db.SaveChanges();
                MessageBox.Show("Datos Fueron Eliminados Correctamente");
                DCliente.ItemsSource = db.Tiempos.ToList();
                DCliente.DisplayMemberPath = "IDCliente";
                DCliente.SelectedValuePath = "IDCliente";
                DCliente.SelectedIndex = 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            int id = (Int32)DCliente.SelectedValue;

            var temp = db.Clientes.SingleOrDefault(s => s.IDCliente == id);


            if (temp != null)
            {
                temp.NombreC = (String)txt1.Text;
                temp.Tel = Convert.ToInt32(txt2.Text);
                temp.Correo = (String)txt3.Text;
                db.SaveChanges();
                MessageBox.Show("Datos Fueron Actualizado Correctamente");
            }
        }

        private void DeCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            DCliente.ItemsSource = db.Tiempos.ToList();
            DCliente.DisplayMemberPath = "IDCliente";
            DCliente.SelectedValuePath = "IDCliente";
            DCliente.SelectedIndex = 0;
        }

        private void DCliente_Loaded(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD();
            DCliente.ItemsSource = db.Productos.ToList();
            DCliente.DisplayMemberPath = "IDCliente";
            DCliente.SelectedValuePath = "IDCliente";
            DCliente.SelectedIndex = 0;
        }
    }
}
