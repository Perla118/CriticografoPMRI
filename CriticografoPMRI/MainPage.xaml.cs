using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CriticografoPMRI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;

            string gen = (Hombre.IsChecked ? "hombre" : "mujer");


            var cosas = new System.Collections.Generic.List<string>();


            if (ALTO.IsChecked)
                cosas.Add(gen == "hombre" ? "alto" : "alta");

            if (FEO.IsChecked)
                cosas.Add(gen == "hombre" ? "feo" : "fea");

            if (LISTO.IsChecked)
                cosas.Add(gen == "hombre" ? "listo" : "lista");

            if (EXTRAVAGANTE.IsChecked)
                cosas.Add(gen == "hombre" ? "extravagante" : "extravagante");

            if (RARO.IsChecked)
                cosas.Add(gen == "hombre" ? "raro" : "rara");

            if (GRANDE.IsChecked)
                cosas.Add(gen == "hombre" ? "grande" : "grande");

            string critica = $"{nombre} es {string.Join(", ", cosas)}";

            Resultado.Text = critica;
        }
    }
}
