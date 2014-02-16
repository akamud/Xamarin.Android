using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace Exercicio7
{
    [Activity(Label = "Exercicio7", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        WebView web_view;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            web_view = FindViewById<WebView>(Resource.Id.webview);
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("http://www.dogeweather.com");
        }
    }
}

