using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ahorcado_Xamarin
{
    public partial class MainPage : ContentPage
    {
        readonly string [] PALABRAS = { "IRIDISCENTE", "MURCIELAGO", "EMU", "VILLANCICO" };
        readonly string[] LETRAS = {
            "A", "B","C","D","E","F","G",
            "H","I","J","K","L","M","N",
            "Ñ","O","P","Q","R","S","T",
            "U","V","W","X","Y","Z","*",
        };
        string palabraSecreta;
        string palabraAdivinar;
        string palabraDescubierta;
        int numFallos;
        int numAciertos;
        public MainPage()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            numAciertos = 0;
            numFallos = 0;
            Img_Ahorcado.Source = ImageSource.FromResource("Ahorcado_Xamarin.images.image0.png");
            InicializarPalabraSecreta();
            InicializarBotonera();
        }
        private void InicializarPalabraSecreta()
        {
            Random rnd = new Random();
            int numeroPalabra = rnd.Next(0, PALABRAS.Length);
            palabraSecreta = PALABRAS[numeroPalabra];
            palabraDescubierta = "";

            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                palabraDescubierta += "- ";

            }
            Lbl_Palabra.Text = palabraDescubierta;

        }
        private void InicializarBotonera()
        {
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 7; columna++)
                {
                    Button boton = new Button
                    {
                        Text = LETRAS[fila * 7 + columna]
                    };
                    Grd_botonera.Children.Add(boton, columna, fila) ;
                    boton.Clicked += Boton_Clicked;

                }
            }
        }

        private void Boton_Clicked(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            string letraPulsada = botonPulsado.Text;
            if (LetraAcertada(botonPulsado.Text))
            {

            }
        }

        private bool LetraAcertada(string letraPulsada)
        {
            bool hayAcierto = false;
            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                if (palabraSecreta[i]==letraPulsada)
                {
                    palabraAdivinar
                        jaksldfjalksdj

                }

            }

            return hayAcierto;
        }
    }
}
