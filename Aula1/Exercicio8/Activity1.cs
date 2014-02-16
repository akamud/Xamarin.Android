using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Exercicio8
{
    [Activity(Label = "Exercicio8", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button botao = FindViewById<Button>(Resource.Id.btnConfirmar);
            botao.Click += botao_Click;
        }

        private void botao_Click(object sender, EventArgs e)
        {
            TextView txtNumero = FindViewById<TextView>(Resource.Id.txtNumero);
            TextView txtNome = FindViewById<TextView>(Resource.Id.txtNome);
            TextView txtData = FindViewById<TextView>(Resource.Id.txtData);
            TextView txtEndereco = FindViewById<TextView>(Resource.Id.txtEndereco);
            TextView txtCep = FindViewById<TextView>(Resource.Id.txtCep);
            TextView txtEmail = FindViewById<TextView>(Resource.Id.txtEmail);

            EditText editNumero = FindViewById<EditText>(Resource.Id.editNumero);
            EditText editNome = FindViewById<EditText>(Resource.Id.editNome);
            EditText editData = FindViewById<EditText>(Resource.Id.editData);
            EditText editEndereco = FindViewById<EditText>(Resource.Id.editEndereco);
            EditText editCep = FindViewById<EditText>(Resource.Id.editCep);
            EditText editEmail = FindViewById<EditText>(Resource.Id.editEmail);

            ImageView imgView = FindViewById<ImageView>(Resource.Id.image_view);

            txtNumero.Text = editNumero.Text;
            txtNome.Text = editNome.Text;
            txtData.Text = editData.Text;
            txtEndereco.Text = editEndereco.Text;
            txtCep.Text = editCep.Text;
            txtEmail.Text = editEmail.Text;

            imgView.SetImageResource(Resource.Drawable.logo);
        }
    }
}

