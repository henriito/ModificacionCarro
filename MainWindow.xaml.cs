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
using WpfAprendiendo.Clases;

namespace WpfAprendiendo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Carrazo man = new Carrazo("Hyundai", "Henry");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BttnEncender_Click(object sender, RoutedEventArgs e)
        {
            Encendidomsg.Text =  man.EncenderMotor();
        }

        private void BttnAcelerar_Click(object sender, RoutedEventArgs e)
        {
            Acelerarmsg.Text = man.acelerar();
        }

        private void BttnBajarVel_Click(object sender, RoutedEventArgs e)
        {
            Desacelerarmsg.Text = man.desacelerar();
        }

        private void BttnFrenar_Click(object sender, RoutedEventArgs e)
        {
            Frenarmsg.Text = man.frenar();
        }

        private void BttnApagar_Click(object sender, RoutedEventArgs e)
        {
            Apagarmsg.Text = man.apagar();
        }
    }

}
