using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool pausado = false;

        private void playBoton_Click(object sender, RoutedEventArgs e)
        {
            reproductorMediaElement.Play();   
        }

        private void reanudarBoton_Click(object sender, RoutedEventArgs e)
        {
            if (!pausado)
            {
                reproductorMediaElement.Pause();
                pausado = true;
            }
            else
            {
                reproductorMediaElement.Play();
                pausado = false;
            }
        }

        private void stopBoton_Click(object sender, RoutedEventArgs e)
        {
            reproductorMediaElement.Close();
        }

        private void mediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            reproductorMediaElement.Close();

            if (e.OriginalSource == trailer1RadioButton)
                reproductorMediaElement.Source = new Uri(@"E:\2 DAM\DI\Tema 2\Ejercicios\Reproductor\Reproductor\Reproductor\trailer1.mp4");
            
            else
                reproductorMediaElement.Source = new Uri(@"E:\2 DAM\DI\Tema 2\Ejercicios\Reproductor\Reproductor\Reproductor\trailer2.mp4");
            
        }

        private void silenciarCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (silenciarCheckBox.IsChecked.Value)
                reproductorMediaElement.IsMuted = true;
            else
                reproductorMediaElement.IsMuted = false;
        }
    }
}
