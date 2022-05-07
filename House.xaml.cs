using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HomeSolarSolutions
{
    /// <summary>
    /// Interaction logic for House.xaml
    /// </summary>
    /// 
    
    public partial class House : Window
    {
        public readonly MainWindow _mainWindow;
        public House(MainWindow mainwin)
        {
            _mainWindow = mainwin;
            InitializeComponent();
           
        }
    }
}
