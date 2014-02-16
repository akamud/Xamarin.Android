using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Exercicio4
{
    [Activity(Label = "Exercicio4", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var gridview = FindViewById<GridView>(Resource.Id.gridview);
            gridview.Adapter = new ImageAdapter(this);

            gridview.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            };
        }
    }
}

