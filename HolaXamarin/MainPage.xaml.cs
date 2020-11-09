using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            List<string> lPaises = new List<string>();
            lPaises.Add("El Salvador");
            lPaises.Add("Honduras");
            lPaises.Add("Guatemala");
            pPais.ItemsSource = lPaises;            
            
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            string strEstadoCivil = "";
            if(chkEstadoCivil.IsChecked)
            {
                strEstadoCivil = "Casado";
            }
            else
            {
                strEstadoCivil = "Soltero";
            }

            await DisplayAlert("Saludo", "Hola tú eres" + txtNombre.Text + " y naciste el: " + dpFechaNacimiento.Date.ToString("dd-MM-yyyy")
                + " tu estado civil es: " +  strEstadoCivil + " País de origen: " + pPais.SelectedItem.ToString(), "OK");                
        }
    }
}
