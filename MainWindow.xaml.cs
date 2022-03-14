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

namespace HomeSolarSolutions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavToMapUSA(object sender, RoutedEventArgs e)
        {
            //Window1 Win1 = new Window1(this);
            MapUSA map = new MapUSA(this);
            map.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            float number;
            if (JanInfo.Text == null || JanInfo.Text == "")
            {
               ArrayErrorMessageBlock.Text = "Use the Map button to choose your location.";
            }

            else
            {
                foreach (char c in arraySize.Text)
                {
                    bool passTest = float.TryParse(arraySize.Text, out number);
                    ArrayErrorMessageBlock.Text = "";
                    if (passTest)
                    {
                        float sizeInKw = float.Parse(arraySize.Text);
                        float sizeInWatts = sizeInKw / 1000;
                        
                        MyArrayJan.Text = (float.Parse(JanInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayFeb.Text = (float.Parse(FebInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayMar.Text = (float.Parse(MarInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayApr.Text = (float.Parse(AprInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayMay.Text = (float.Parse(MayInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayJun.Text = (float.Parse(JunInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayJul.Text = (float.Parse(JulInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayAug.Text = (float.Parse(AugInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArraySep.Text = (float.Parse(SepInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayOct.Text = (float.Parse(OctInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayNov.Text = (float.Parse(NovInfo.Text) * sizeInWatts).ToString("N2") + " W";
                        MyArrayDec.Text = (float.Parse(DecInfo.Text) * sizeInWatts).ToString("N2") + " W";

                    }
                    else
                    {
                        ArrayErrorMessageBlock.Text = "Please input numbers only";
                    }
                }
            }
        }
    }
}
