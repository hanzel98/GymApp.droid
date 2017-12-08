using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GymApp
{
    [Activity(Theme= "@style/MyTheme3", Label = "Rutinas")]
    public class Rutina_layout : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Rutina);
            // Create your application here
            
            string BDNombreRutina = Intent.GetStringExtra("NombreRutina");
            string BDNombreEjercicio = Intent.GetStringExtra("NombreEjercicio");
            string BDCantidadSeries = Intent.GetStringExtra("CantidadRepeticiones");
            string BDCantidadRepeticiones = Intent.GetStringExtra("CantidadSeries");
            string BDDescanso = Intent.GetStringExtra("Descanso");


            TextView NombreEjercicio = FindViewById<TextView>(Resource.Id.NombreEjercicio);
            TextView NombreRutina = FindViewById<TextView>(Resource.Id.NombreRutina);
            TextView Series = FindViewById<TextView>(Resource.Id.NumeroSeries);
            TextView Repeticiones = FindViewById<TextView>(Resource.Id.NumeroRepeticiones);
            TextView Descanso = FindViewById<TextView>(Resource.Id.Descanso);


            //Asignación de datos en el layout Pago
            NombreRutina.Text += BDNombreRutina;
            NombreEjercicio.Text += BDNombreEjercicio;
            Series.Text += BDCantidadSeries;
            Repeticiones.Text += BDCantidadRepeticiones;
            Descanso.Text += BDDescanso+" min";



        }
    }
}