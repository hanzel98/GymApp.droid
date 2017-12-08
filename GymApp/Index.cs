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
using System.Xml;


namespace GymApp
{
    [Activity(Theme = "@style/MyTheme3", Label = "Index")]
    public class Index : Activity
    {
        TabHost th;
        TabHost.TabSpec spec;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Index);
            th = (Android.Widget.TabHost)FindViewById(Resource.Id.tabHost1);
            try
            {
                th.Setup();

                spec = th.NewTabSpec("tab1");
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                var drawableIcon1 = Resources.GetDrawable(id: Resource.Drawable.informacion);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                spec.SetContent(Resource.Id.linearLayout1);
                TextView Nombre = FindViewById<TextView>(Resource.Id.Nombre);
                TextView Peso = FindViewById<TextView>(Resource.Id.Peso);
                TextView PorcentajeDeGrasa = FindViewById<TextView>(Resource.Id.PorcentajeDeGrasa);
                TextView PorcentajeDeAgua = FindViewById<TextView>(Resource.Id.PorcentajeDeAgua);
                TextView IndiceDeMasaCorporal = FindViewById<TextView>(Resource.Id.IndiceDeMasaCorporal);
                TextView Pecho = FindViewById<TextView>(Resource.Id.Pecho);
                TextView Espalda = FindViewById<TextView>(Resource.Id.Espalda);
                TextView Brazo = FindViewById<TextView>(Resource.Id.Brazo);
                TextView Cintura = FindViewById<TextView>(Resource.Id.Cintura);
                TextView Abdomen = FindViewById<TextView>(Resource.Id.Abdomen);
                TextView Cadera = FindViewById<TextView>(Resource.Id.Cadera);
                TextView Muslo = FindViewById<TextView>(Resource.Id.Muslo);
                TextView Pantorrilla = FindViewById<TextView>(Resource.Id.Pantorrilla);
                
                DatosInformacion Datos = new DatosInformacion();
                try
                {
                    //conexion Mysql 
                    MySQLCon db = new MySQLCon();
                    Datos = db.Datillo(MainActivity.Usuario,MainActivity.Contraseña);
                    
                    //lista usuarios y contraseñas
                    Nombre.Text += Datos.Nombre;
                    Peso.Text += Datos.Peso;
                    PorcentajeDeGrasa.Text += Datos.PorcentajeDeGrasa;
                    PorcentajeDeAgua.Text += Datos.PorcentajeDeAgua;
                    IndiceDeMasaCorporal.Text += Datos.IndiceDeMasaCorporal;
                    Pecho.Text += Datos.Pecho;
                    Espalda.Text += Datos.Espalda;
                    Brazo.Text += Datos.Brazo;
                    Cintura.Text += Datos.Cintura;
                    Abdomen.Text += Datos.Abdomen;
                    Cadera.Text += Datos.Cadera;
                    Muslo.Text += Datos.Muslo;
                    Pantorrilla.Text += Datos.Pantorrilla;
                    
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, "Error: " + ex.Message, ToastLength.Short).Show();
                }
                
                spec.SetIndicator("", drawableIcon1);

                th.AddTab(spec);




















                spec = th.NewTabSpec("tab2");
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                var drawableIcon2 = Resources.GetDrawable(id: Resource.Drawable.rutinas);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                spec.SetContent(Resource.Id.linearLayout2);
                spec.SetIndicator("", drawableIcon2);
                th.AddTab(spec);

                spec = th.NewTabSpec("tab3");
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                var drawableIcon3 = Resources.GetDrawable(Resource.Drawable.pago);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                spec.SetContent(Resource.Id.linearLayout3);
                spec.SetIndicator("", drawableIcon3);
                th.AddTab(spec);
            }
            catch (Exception e)
            {
                Toast.MakeText(this, "Hubo un error", ToastLength.Long).Show();
            }
            
        }
    }
}
