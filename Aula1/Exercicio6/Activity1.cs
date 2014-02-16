using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Exercicio6
{
    [Activity(Label = "Exercicio6", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : ListActivity
    {
        string[] items;
        int[] icones;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            items = new string[] { "Please Please Me|1963", "With The Beatles|1963", "A Hard Day's Night|1964", "Beatles For Sale|1964", "Help!|1965", "Rubber Soul|1965", "Revolver|1966",
                                    "Sgt. Pepper's Lonely Hearts Club Band|1967", "Magical Mystery Tour|1967", "White Album|1968", "Yellow Submarine|1969", "Abbey Road|1969", "Let It Be|1970"};
            icones = new int[] { Resource.Drawable.pleasePleaseMe, Resource.Drawable.withTheBeatles, Resource.Drawable.hardDaysNight, Resource.Drawable.beatlesForSale, Resource.Drawable.help,
                                    Resource.Drawable.rubberSoul, Resource.Drawable.revolver, Resource.Drawable.sgtPeppers, Resource.Drawable.magicalMysteryTour, Resource.Drawable.whiteAlbum,
                                    Resource.Drawable.yellowSubmarine, Resource.Drawable.abbeyRoad, Resource.Drawable.letItBe};
            ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItem1, items, icones);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.application_menu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.umaLinha:
                    ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItem1, items);
                    return true;
                case Resource.Id.duasLinhasTitulo:
                    ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItem2, items);
                    return true;
                case Resource.Id.duasLinhasIguais:
                    ListAdapter = new CustomAdapter(this, Android.Resource.Layout.TwoLineListItem, items);
                    return true;
                case Resource.Id.comIcone:
                    ListAdapter = new CustomAdapter(this, Android.Resource.Layout.ActivityListItem, items, icones);
                    return true;
                case Resource.Id.textoComCheck:
                    ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItemChecked, items);
                    ListView.ChoiceMode = ChoiceMode.Multiple;
                    return true;
                case Resource.Id.textoComRadio:
                    ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItemSingleChoice, items);
                    ListView.ChoiceMode = ChoiceMode.Single;
                    return true;
                case Resource.Id.textoComCheckBox:
                    ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItemMultipleChoice, items);
                    ListView.ChoiceMode = ChoiceMode.Multiple;
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}

