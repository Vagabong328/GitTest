using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Vaga
{
    /// <summary>
    /// Логика взаимодействия для Robo.xaml
    /// </summary>
    public partial class Robo : Page
    {
        public Robo()
        {
            InitializeComponent();
            
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
          Process.Start("https://vagabong328.github.io/guts/");
        }
    }
}
