using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppMamaLucha.Resources.Negocios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AppMamaLucha
{
    [Activity(Label = "AgregarProducto")]
    public class AgregarProducto : Activity
    {
        EditText edtCodigo, edtnombre, edtprecio;
        ImageView imgProduct;
        Button btnAgregarimagen, btnGuardar;
        Button btnSalir;
        private byte[] bitmapData;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AgregarProducto);

            edtCodigo = (EditText)FindViewById(Resource.Id.editCodigo);
            edtnombre= (EditText)FindViewById(Resource.Id.editProducto);
            edtprecio = (EditText)FindViewById(Resource.Id.editprecio);
            btnAgregarimagen = (Button)FindViewById(Resource.Id.btnsubr); 
            btnGuardar = (Button)FindViewById(Resource.Id.guarda);
            btnSalir = (Button)FindViewById(Resource.Id.btSalir);
       

            btnAgregarimagen.Click += btnAgregarimagen_click;
            btnGuardar.Click += btnGuardar_click;
            //btnSalir.Click += Btnsalir_Click;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGuardar_click(object sender, EventArgs e)
        {
            try
            {
            if(!string.IsNullOrWhiteSpace(edtCodigo.Text) && !string.IsNullOrWhiteSpace(edtnombre.Text) && !string.IsNullOrWhiteSpace(edtprecio.Text) )
            {
                    Articulos.setProducto(edtCodigo.Text, edtnombre.Text, double.Parse(edtprecio.Text));
                   
                    Toast.MakeText(this,edtCodigo.Text+ " "+edtnombre.Text+" "+edtprecio.Text, ToastLength.Long).Show();

                }
            }
            catch (Exception ex)
            {

                Toast.MakeText(this, "error" + ex.Message, ToastLength.Long).Show();
            }
            
        }

        private void btnAgregarimagen_click(object sender, EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            StartActivityForResult(intent, 0);
        }
        protected override void OnActivityResult(int requetsCode,[GeneratedEnum] Result resultCode,Intent data)
        {
            base.OnActivityResult(requetsCode, resultCode, data);
            Android.Graphics.Bitmap bitmap= (Android.Graphics.Bitmap)data.Extras.Get("data");
            imgProduct.SetImageBitmap(bitmap);
            using (var stream = new MemoryStream())
            {
                bitmap.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 0, stream);
                bitmapData = stream.ToArray();
            }
        }
        
    }
}