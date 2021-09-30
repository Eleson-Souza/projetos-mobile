using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tp01.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonOKClicked(object sender, EventArgs e)
        {
            string id = txtId.Text?.ToString();
            string pass = txtPass.Text?.ToString();
            
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pass))
                DisplayAlert("Login", "Preencha todos os campos.", "OK");
            else if (id == "admin" && pass == "senha@dmin")
                DisplayAlert("Login", "Login realizado com sucesso!", "OK");
            else
                DisplayAlert("Login", "Email e/ou senha incorreto(s)! \n\nLogin não autorizado!", "OK");
        }

        private void ButtonClearClicked(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPass.Text = "";
            txtId.Focus();
        }

        private void ButtonCreditsClicked(object sender, EventArgs e)
        {
            DisplayAlert("©Créditos", "Eleson de Souza Oliveira\nLucas Sérgio Denhei Alexandre", "OK");
        }
    }
}