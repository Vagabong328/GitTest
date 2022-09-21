using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vaga
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    { 
        string path = "mydoc.xaml";
       
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open(path, FileMode.Create))
            {
                if (docViewer.Document != null)
                {
                    XamlWriter.Save(docViewer.Document, fs);
                    MessageBox.Show("Файл сохранен");
                }
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            docViewer.ClearValue(FlowDocumentScrollViewer.DocumentProperty);
        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                FlowDocument document = XamlReader.Load(fs) as FlowDocument;
                if (document != null)
                    docViewer.Document = document;
            }
        }
    }
}
