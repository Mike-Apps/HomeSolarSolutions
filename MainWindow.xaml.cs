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
                //arraySize.Text = "1";
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

                        MyArrayJan.Text = (float.Parse(JanInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayFeb.Text = (float.Parse(FebInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayMar.Text = (float.Parse(MarInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayApr.Text = (float.Parse(AprInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayMay.Text = (float.Parse(MayInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayJun.Text = (float.Parse(JunInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayJul.Text = (float.Parse(JulInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayAug.Text = (float.Parse(AugInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArraySep.Text = (float.Parse(SepInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayOct.Text = (float.Parse(OctInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayNov.Text = (float.Parse(NovInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";
                        MyArrayDec.Text = (float.Parse(DecInfo.Text.Remove(JanInfo.Text.Length - 4)) * sizeInWatts).ToString("N2") + " W/h";

                        maxInstantPower.Text = (float.Parse(maxInstPower1KW_Textblock.Text) * sizeInWatts).ToString("N2") + " W";


                    }
                    else
                    {
                        ArrayErrorMessageBlock.Text = "Please input numbers only";
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            House house = new House(this);
            house.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string message = "NREL https://www.nrel.gov/ for the beautiful Map.\n" +
                "Sengupta, M., Y. Xie, A. Lopez, A. Habte, \n" +
                "G. Maclaurin, and J. Shelby. 2018.\n" +
                "The National Solar Radiation Data Base(NSRDB).\n" +
                "Renewable and Sustainable Energy Reviews  89 (June): 51-60.\n" +
                "\n" +
                "and\n" +
                "\n" +
                "https://globalsolaratlas.info \n" +
                " for power availability based on area data";


            MessageBox.Show(message,"Special Thanks to: ", MessageBoxButton.OK);
        }
    }
}
