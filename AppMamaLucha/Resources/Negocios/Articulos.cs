using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using AppMamaLucha.Resources.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMamaLucha.Resources.Negocios
{
    public class Articulos
    {
        public static List<Electrodomesticos> articulos = new List<Electrodomesticos>();
        public static void AgregarProducto()
        {
            articulos.Add(new Electrodomesticos("1234","Arroz",300));
            articulos.Add(new Electrodomesticos("1254", "Coca cola",50));
        }
        public static void setProducto(string Codigo,string nombre,double precio)
        {
            articulos.Add(new Electrodomesticos(Codigo,nombre,precio));
        }
    }
}