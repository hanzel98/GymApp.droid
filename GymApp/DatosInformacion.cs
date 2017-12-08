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
    public class DatosInformacion
    {
        public string Nombre { get; set; }
        public string Peso { get; set; }
        public string PorcentajeDeGrasa { get; set; }
        public string PorcentajeDeAgua { get; set; }
        public string IndiceDeMasaCorporal { get; set; }
        public string Pecho { get; set; }
        public string Espalda { get; set; }
        public string Brazo { get; set; }
        public string Cintura { get; set; }
        public string Abdomen { get; set; }
        public string Cadera { get; set; }
        public string Muslo { get; set; }
        public string Pantorrilla { get; set; }
    }
}