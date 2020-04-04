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

namespace Calkul
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //MainWindow.ui += label_TextInput;




            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);


        }

        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {

           
            if (e.Key == Key.OemQuotes)
                label1.Content+= "'"; // добавляем кавычки
            else
                label1.Content += e.Key.ToString();

        }


    }
}
