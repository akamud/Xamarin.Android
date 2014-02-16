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

namespace Exercicio6
{
    public class CustomAdapter : BaseAdapter<string>
    {
        string[] items;
        int[] icones;
        Activity context;
        int resource;

        public CustomAdapter(Activity context, int resource, string[] items, int[] icones = null)
            : base()
        {
            this.resource = resource;
            this.context = context;
            this.items = items;
            this.icones = icones;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override string this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Length; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
            {
                view = context.LayoutInflater.Inflate(resource, null);
            }
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = items[position].Split('|')[0];

            if (resource == Android.Resource.Layout.SimpleListItem2 || resource == Android.Resource.Layout.TwoLineListItem)
            {
                view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = items[position].Split('|')[1];
            }
            if (resource == Android.Resource.Layout.ActivityListItem)
            {
                view.FindViewById<ImageView>(Android.Resource.Id.Icon).SetImageResource(icones[position]);
            }
            
            return view;
        }
    }
}