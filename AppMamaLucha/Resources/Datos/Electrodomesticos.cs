using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMamaLucha.Resources.Datos
{
     public class Electrodomesticos
    {
        public Electrodomesticos(string codigoProd, string nombreProduc, double precio)
        {
            CodigoProd = codigoProd;
            NombreProduc = nombreProduc;
            Precio = precio;
            
        }

        public string CodigoProd { get; set; }
        public string NombreProduc { get; set; }
        public double Precio { get; set; }

    }
}