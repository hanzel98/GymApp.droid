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
            
            //Manda a crear la conexion y obtiene los datos
            DatosInformacion Datos = new DatosInformacion();
            try
            {
                //conexion Mysql 
                MySQLCon  db = new MySQLCon();
                Datos = db.ConsigueDatos(MainActivity.Usuario, MainActivity.Contraseña);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Error: " + ex.Message, ToastLength.Short).Show();
            }



            th = (Android.Widget.TabHost)FindViewById(Resource.Id.tabHost1);
            try
            {
                th.Setup();
//------------------------------------------------------------------------------------------------------------------------------------
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

                //Asignación de datos en el layout Información
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
                
                spec.SetIndicator("", drawableIcon1);
                th.AddTab(spec);

//-----------------------------------------------------------------------------------------------------------------------------------
                spec = th.NewTabSpec("tab2");
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                var drawableIcon2 = Resources.GetDrawable(id: Resource.Drawable.rutinas);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                spec.SetContent(Resource.Id.linearLayout2);

                Button botonRutina = FindViewById<Button>(Resource.Id.btnRutina1);
                botonRutina.Click += delegate
                {
                    Intent intent = new Intent(this, typeof(Rutina_layout));

                    intent.PutExtra("NombreRutina", Datos.NombreRutina);
                    intent.PutExtra("NombreEjercicio", Datos.NombreEjercicio);
                    intent.PutExtra("CantidadRepeticiones", Datos.Repeticiones);
                    intent.PutExtra("CantidadSeries", Datos.Series);
                    intent.PutExtra("Descanso", Datos.Descanso);
                    StartActivity(intent);
                };

                spec.SetIndicator("", drawableIcon2);
                th.AddTab(spec);
                
//----------------------------------------------------------------------------------------------------------------------------------
                spec = th.NewTabSpec("tab3");
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                var drawableIcon3 = Resources.GetDrawable(Resource.Drawable.pago);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                spec.SetContent(Resource.Id.linearLayout3);


                TextView FechaDeUltimoPago = FindViewById<TextView>(Resource.Id.FechaDeUltimoPago);
                TextView FechaDePagoSiguiente = FindViewById<TextView>(Resource.Id.FechaDePagoSiguiente);
                TextView DiasRestantes = FindViewById<TextView>(Resource.Id.DiasRestantes);

                Datos.FechaDeUltimoPago = "12/12/12";
                Datos.FechaDePagoSiguiente = "1/1/13";
                Datos.DíasRestantes = "31 dias";

                FechaDeUltimoPago.Text = Datos.FechaDeUltimoPago;
                FechaDePagoSiguiente.Text = Datos.FechaDePagoSiguiente;
                DiasRestantes.Text = Datos.DíasRestantes;

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
