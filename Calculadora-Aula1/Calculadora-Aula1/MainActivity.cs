using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Calculadora_Aula1
{
    [Activity(Label = "Calculadora_Aula1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnSomar;
        TextView tvResultado;
        EditText nedN1, nedN2;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            nedN1 = (EditText)FindViewById(Resource.Id.nedN1);
            nedN2 = (EditText)FindViewById(Resource.Id.nedN2);
            btnSomar = (Button)FindViewById(Resource.Id.btnSomar);
            tvResultado = (TextView)FindViewById(Resource.Id.tvResultado);

            btnSomar.Click += BtnSomar_Click;
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            double a, b, res;
            a = double.Parse(nedN1.Text);
            b = double.Parse(nedN2.Text);
            res = a + b;
            tvResultado.Text = res.ToString();
        }
    }
}

