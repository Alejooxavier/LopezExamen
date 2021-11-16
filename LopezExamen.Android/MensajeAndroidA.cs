using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LopezExamen.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(MensajeAndroidA))]
namespace LopezExamen.Droid
{
    class MensajeAndroidA : Mensaje
    {
        public void longAlert(string mensaje)
        {
            //el mensaje se almecene en un periodo de 5 s
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();
        }

        public void shortAlert(string mensaje)
        {
            //el mensaje se almecene en un periodo de 5 s
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}