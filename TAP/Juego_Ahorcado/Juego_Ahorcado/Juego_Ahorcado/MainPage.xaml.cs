using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Juego_Ahorcado
{
    public partial class MainPage : ContentPage
    {
        List<Button> buttons;       //Botones que usaremos
        List<ImageSource> Images;   //Imagenes que usaremos
        List<Label> fieldChar;      //textos
        string word;                //palabra para el juego
        int counterMiss = 0;        //contador de errores

        public MainPage()
        {
            InitializeComponent();
            Images = new List<ImageSource>();   //Genera la lista de imagenes
            LoadImage();                        //Carga las imágenes
            DoWordArea();                       //Carga el área de las letras
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            DoWordArea();
        }
        private void LoadImage()    //Carga las imagenes del ahorcado
        {
            for (int i = 0; i < 10; i++)
            {
                ImageSource image = ImageSource.FromFile("Hangman" +
                i.ToString() + ".png");
                Images.Add(image);
            }
        }
        private void CreateKeyboard()   //Crea el teclado tactil de la app
        {
            buttons = new List<Button>();
            firstRow.Children.Clear();
            secondRow.Children.Clear();
            thirdRow.Children.Clear();
            for (int i = 65; i < 91; i++)   //Genera los botones que contendrán cada una de las letras
            {
                Button button = new Button
                {
                    Text = ((char)i).ToString(),
                    FontSize = 22,
                    WidthRequest = 40,
                    HeightRequest = 50
                };
                button.Clicked += btnClickey;
                if (i % 65 < 8) firstRow.Children.Add(button);
                else if (i % 65 >= 8 && i % 65 < 17)
                    secondRow.Children.Add(button);
                else thirdRow.Children.Add(button);
                buttons.Add(button);
            }
        }
        private void btnClickey(object sender, EventArgs e) //Obtiene el contenido del botón presionado
        {
            Button button = sender as Button;
            string character = button.Text.ToString();
            bool hit = false;
            for (int i = 1; i < this.word.Length - 1; i++)
            {
                if (this.word[i].ToString().ToLower() == character.ToLower())
                {
                    hit = true;
                    fieldChar[i].Text = character.ToLower();
                }
            }
            if (hit == false)   //Va contando cada letra erronea
            {
                counterMiss += 1;
                imageMiss.Source = Images[counterMiss];
            }
            if (counterMiss == 9)   //Mensaje de perdición
            {
                DisplayAlert("Que sad", "Perdiste", "Jugar de nuevo");
            }
            int count = 0;
            for (int i = 0; i < this.word.Length; i++)
            {
                if (fieldChar[i].Text != "-")
                    count++;
            }
            if (count == this.word.Length)  //mensaje ganador
            {
                DisplayAlert("Felicidades", "Ganaste", "Jugar de nuevo");
            }
            button.IsEnabled = false;
        }
        private string RandomWord() //elige aleatoriamente la palabra que tendrá el juego
        {
            string[] words = { "perro", "gato", "beisbol", "programa", "casa",
"manzana", "sol", "pera" };
            Random r = new Random();
            return words[r.Next(words.Length)];
        }
        private void DoWordArea()   //oculta el contenido de la mayoría de las letras
        {
            counterMiss = 0;
            CreateKeyboard();
            this.word = RandomWord();
            imageMiss.Source = Images[0];
            fieldChar = new List<Label>();
            WordArea.Children.Clear();
            for (int i = 0; i < this.word.Length; i++)
            {
                Label label = new Label()
                {
                    Text = "-",
                    Margin = new Thickness(10),
                    FontSize = 50,
                    TextColor = Color.White
                };
                WordArea.Children.Add(label);
                fieldChar.Add(label);
            }
            fieldChar[0].Text = this.word[0].ToString();
            fieldChar[this.word.Length - 1].Text = this.word[this.word.Length -
            1].ToString();
        }
    }
}
