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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using BaseDatos.BD;

namespace BaseDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseDatos.BD.Producto tempP = null;
        private List<BaseDatos.BD.Producto> Cartas;
        public MainWindow()
        {
            InitializeComponent();
            Cartas = new List<BaseDatos.BD.Producto>();
        }
        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            BaseDatos.BD.MiBD bd = new BD.MiBD();
            DFactura.ItemsSource = bd.Productoss.ToList();
            DFactura.SelectedValuePath = "IDCodigo";
            DFactura.DisplayMemberPath = "NombreP";
        }
        private void DFactura_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void DFactura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void DeFactura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DFactura.SelectedIndex = -1;
            txt1.Text = String.Empty;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MiBD db = new MiBD();
            int id = (int)DFactura.SelectedValue;
            BaseDatos.BD.Producto p = db.Productoss.SingleOrDefault(x => x.IDCodigo == id);
            tempP = p;
            Cartas.RemoveAll(s => s.IDCodigo == tempP.IDCodigo);
            Cartas.Add(new BaseDatos.BD.Producto()
            {
                IDCodigo = tempP.IDCodigo,
                NombreP = tempP.NombreP,
                NombreCa = tempP.NombreCa,
                Precio = tempP.Precio,
            });
            Virtus();
            tempP = null;
        }
        private void Virtus()
        {
            var FullCartas = from s in Cartas
                             select new
                             {
                                 s.IDCodigo,
                                 s.NombreP,
                                 s.NombreCa,
                                 s.Precio
                             };
            DeFactura.ItemsSource = null;
            DeFactura.ItemsSource = FullCartas;
            //cTotal.Content = string.Format("Total:{0}",Cartas.Sum(x=> x.Precio).ToString("C"));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Cartas.Count > 0 && DFactura.SelectedIndex > -1)
            {
                using (BaseDatos.BD.MiBD db = new BaseDatos.BD.MiBD())
                {
                    using (var trans = db.Database.BeginTransaction())
                    {
                        try
                        {
                            BaseDatos.BD.Ventas fact = new BaseDatos.BD.Ventas();
                            BaseDatos.BD.Producto cart = new BaseDatos.BD.Producto();
                        }
                    }
                }
            }
        }
    }
}

