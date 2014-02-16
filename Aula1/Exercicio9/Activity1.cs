using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Exercicio9
{
    [Activity(Label = "Exercicio9", MainLauncher = true, Icon = "@drawable/icon")]
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
            TextView txtSenha = FindViewById<TextView>(Resource.Id.txtSenha);
            TextView txtOpcaoCheckbox = FindViewById<TextView>(Resource.Id.txtCheckbox);
            TextView txtTamanho = FindViewById<TextView>(Resource.Id.txtTamanho);
            TextView txtValor = FindViewById<TextView>(Resource.Id.txtValor);

            EditText editSenha = FindViewById<EditText>(Resource.Id.editSenha);
            CheckBox cbxOpcao1 = FindViewById<CheckBox>(Resource.Id.cbxOpcao1);
            CheckBox cbxOpcao2 = FindViewById<CheckBox>(Resource.Id.cbxOpcao2);
            CheckBox cbxOpcao3 = FindViewById<CheckBox>(Resource.Id.cbxOpcao3);
            RadioButton radioOpcao1 = FindViewById<RadioButton>(Resource.Id.radioOpcao1);
            RadioButton radioOpcao2 = FindViewById<RadioButton>(Resource.Id.radioOpcao2);
            RadioButton radioOpcao3 = FindViewById<RadioButton>(Resource.Id.radioOpcao3);
            SeekBar seekBar1 = FindViewById<SeekBar>(Resource.Id.seekBar1);

            txtSenha.Text = "Senha: " + editSenha.Text;
            string opcaoSelecionada = String.Empty;
            if (cbxOpcao1.Checked)
            {
                opcaoSelecionada = cbxOpcao1.Text;
            }
            if (cbxOpcao2.Checked)
            {
                opcaoSelecionada = opcaoSelecionada + "," + cbxOpcao2.Text;
            }
            if (cbxOpcao3.Checked)
            {
                opcaoSelecionada = opcaoSelecionada + "," + cbxOpcao3.Text;
            }

            string tamanhoSelecionado = String.Empty;
            if (radioOpcao1.Checked)
            {
                tamanhoSelecionado = radioOpcao1.Text;
            }
            if (radioOpcao2.Checked)
            {
                tamanhoSelecionado = radioOpcao2.Text;
            }
            if (radioOpcao3.Checked)
            {
                tamanhoSelecionado = radioOpcao3.Text;
            }

            txtOpcaoCheckbox.Text = "Opção selecionada: " + opcaoSelecionada;
            txtTamanho.Text = "Tamanho Selecionado: " + tamanhoSelecionado;

            txtValor.Text = "Valor: " + seekBar1.Progress;
        }
    }
}

