using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;

namespace AvaloniaApplication1
{
    public partial class MainWindow : Window
    {
        private Button _Przycisk;
        private ContentControl _Kostka;
        private List<Image> Kostki = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();
            
            for (int i = 0; i < 6; i++)
            {
                Image image= new Image();
                image.Source = new Bitmap(string.Format("../../../kostka{0}.png", i+1));
                Kostki.Add(image);
            }


            _Przycisk = this.FindControl<Button>("Przycisk");
            _Kostka = this.FindControl<ContentControl>("Kostka");

            _Przycisk.Click += RzutKostka;
        }
        private void RzutKostka(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 6);

            _Kostka.Content = Kostki[random];
        }
    }
}