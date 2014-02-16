using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Exercicio5
{
    [Activity(Label = "Exercicio5", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : TabActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            CreateTab(typeof(PerfilActivity), "perfil", "Perfil", Resource.Drawable.ic_tab_perfil);
            CreateTab(typeof(NoticiasActivity), "noticias", "Notícias", Resource.Drawable.ic_tab_noticias);
            CreateTab(typeof(CitacoesActivity), "citacoes", "Citações", Resource.Drawable.ic_tab_citacoes);
            CreateTab(typeof(MensagensActivity), "mensagens", "Mensagens", Resource.Drawable.ic_tab_mensagens);
        }

        private void CreateTab(Type activityType, string tag, string label, int drawableId)
        {
            var intent = new Intent(this, activityType);
            intent.AddFlags(ActivityFlags.NewTask);

            var spec = TabHost.NewTabSpec(tag);
            var drawableIcon = Resources.GetDrawable(drawableId);
            spec.SetIndicator(label, drawableIcon);
            spec.SetContent(intent);

            TabHost.AddTab(spec);
        }
    }
}

