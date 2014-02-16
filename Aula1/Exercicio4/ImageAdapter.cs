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

namespace Exercicio4
{
    public class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count
        {
            get { return thumbIds.Length; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {  
                imageView = new ImageView(context);
                imageView.LayoutParameters = new GridView.LayoutParams(90, 90);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(10,10,10,10);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(thumbIds[position]);
            return imageView;
        }

        int[] thumbIds = {
        Resource.Drawable.doge1, Resource.Drawable.doge2,
        Resource.Drawable.doge3, Resource.Drawable.doge4,
        Resource.Drawable.doge5, Resource.Drawable.doge6,
        Resource.Drawable.doge7, Resource.Drawable.doge8,
        Resource.Drawable.doge9
    };
    }
}