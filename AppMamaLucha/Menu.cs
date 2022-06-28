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

namespace AppMamaLucha
{
    [Activity(Label = "Menu")]
    public class Menu : Activity
    {
        Button btnAgregarProducto;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Menu);
            // Create your application here
            btnAgregarProducto = (Button)FindViewById(Resource.Id.btnagregar);

            btnAgregarProducto.Click += btnAgregarProducto_click;
        }

        private void btnAgregarProducto_click(object sender, EventArgs e)
        { 
            StartActivity(typeof(AgregarProducto));
            Finish();
        }
    }
}