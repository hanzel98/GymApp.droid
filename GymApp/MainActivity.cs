using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;
using Android.Content;

namespace GymApp
{
    [Activity(Theme= "@style/MyTheme3", Label = "GymApp", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private Button btnIngresar;
        public static  string Usuario;
        public static string Contraseña;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);
            
            btnIngresar = FindViewById<Button>(Resource.Id.btnIngresar);
            
            btnIngresar.Click += BtnIngresar_Clicked;
        }

        private void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            Usuario = (FindViewById<TextView>(Resource.Id.espacioUsuario)).Text;
            Contraseña = (FindViewById<TextView>(Resource.Id.espacioContraseña)).Text;
            bool CamposLlenos = ValidaCampos();
            if (CamposLlenos)
            {
                Intent intent = new Intent(this, typeof(Index));
                StartActivity(intent);
            }
            
        }

        public bool ValidaCampos()
        {
            if (!Usuario.Equals("") && !Contraseña.Equals(""))
            {
                Toast.MakeText(this, "Comprobando credenciales", ToastLength.Short).Show();
                return true;
            }
            else
            {
                if (Usuario.Equals(""))
                {
                    Toast.MakeText(this, "Introduzca un usuario", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "Introduzca una contraseña", ToastLength.Long).Show();
                }
                
                return false;
            }
        }
       
    }
}

