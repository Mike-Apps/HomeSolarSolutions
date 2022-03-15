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
using System.Data;
using System.Data.SqlClient;




namespace HomeSolarSolutions
{
    /// <summary>
    /// Interaction logic for MapUSA.xaml
    /// </summary>
    public partial class MapUSA : Window
    {
        private readonly MainWindow _mainWindow; //links MainWindow elements to this class
        
        public MapUSA(MainWindow mainWin)  //links MainWindow elements to this class
        {
            _mainWindow = mainWin;  //links MainWindow elements to this class
            InitializeComponent();
        }

        public void getData(string index)
        {
            String cn_string = Properties.Settings.Default.connection_String;
            SqlConnection cn_connection = new SqlConnection(cn_string);

            //First Query
            String SQLQuery_PanelInfo = $"SELECT optimum_angle, AVGJan, AVGFeb, AVGMar, AVGApr, AVGMay, AVGJune, AVGJuly, AVGAug, AVGSep, AVGOct, AVGNov, AVGDec, max_power_optimum_angle FROM tbl_SolarData WHERE Id = {index}";
            SqlCommand cmd = new SqlCommand(SQLQuery_PanelInfo, cn_connection);

            if (cn_connection.State != ConnectionState.Open)
            {
                cn_connection.Open();
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    _mainWindow.PanelAngle.Text = reader[0].ToString() + " degrees";  //_mainWindow.SolarCalculation...links MainWindow elements to this class


                    _mainWindow.JanInfo.Text = reader[1].ToString();
                    //_mainWindow.JanInfo.Text = (float.Parse(_mainWindow.JanInfo.Text).ToString("N2") + " W");

                    _mainWindow.FebInfo.Text = reader[2].ToString();
                   // _mainWindow.FebInfo.Text = (float.Parse(_mainWindow.FebInfo.Text).ToString("N2") + " W");

                    _mainWindow.MarInfo.Text = reader[3].ToString();
                   // _mainWindow.MarInfo.Text = (float.Parse(_mainWindow.MarInfo.Text).ToString("N2") + " W");

                    _mainWindow.AprInfo.Text = reader[4].ToString();
                   // _mainWindow.AprInfo.Text = (float.Parse(_mainWindow.AprInfo.Text).ToString("N2") + " W");

                    _mainWindow.MayInfo.Text = reader[5].ToString();
                   // _mainWindow.MayInfo.Text = (float.Parse(_mainWindow.MayInfo.Text).ToString("N2") + " W");

                    _mainWindow.JunInfo.Text = reader[6].ToString();
                    //_mainWindow.JunInfo.Text = (float.Parse(_mainWindow.JunInfo.Text).ToString("N2") + " W");

                    _mainWindow.JulInfo.Text = reader[7].ToString();
                   // _mainWindow.JulInfo.Text = (float.Parse(_mainWindow.JulInfo.Text).ToString("N2") + " W");

                    _mainWindow.AugInfo.Text = reader[8].ToString();
                   // _mainWindow.AugInfo.Text = (float.Parse(_mainWindow.AugInfo.Text).ToString("N2") + " W");

                    _mainWindow.SepInfo.Text = reader[9].ToString();
                   // _mainWindow.SepInfo.Text = (float.Parse(_mainWindow.SepInfo.Text).ToString("N2") + " W");

                    _mainWindow.OctInfo.Text = reader[10].ToString();
                    //_mainWindow.OctInfo.Text = (float.Parse(_mainWindow.OctInfo.Text).ToString("N2") + " W");

                    _mainWindow.NovInfo.Text = reader[11].ToString();
                   // _mainWindow.NovInfo.Text = (float.Parse(_mainWindow.NovInfo.Text).ToString("N2") + " W");

                    _mainWindow.DecInfo.Text = reader[12].ToString();
                    //_mainWindow.DecInfo.Text = (float.Parse(_mainWindow.DecInfo.Text).ToString("N2") + " W");

                    _mainWindow.maxInstPower1KW_Textblock.Text = reader[13].ToString();

                    // Maximum power that charge control system must be able to handle based on array size.
                    //string maxinstpower = reader[13].ToString();
                    //float maxInstPowerToFloat = float.Parse(maxinstpower);
                    //string userInputArraySize = _mainWindow.arraySize.Text;
                    //float userInputArraySizeFloat = float.Parse(userInputArraySize);
                    //_mainWindow.maxInstantPower.Text = ((userInputArraySizeFloat / 1000) * maxInstPowerToFloat).ToString();
                }
            }
            
            if (cn_connection.State != ConnectionState.Closed)
            {
                cn_connection.Close();
            }
        }

        private void kelso_button(object sender, RoutedEventArgs e)
        {
            getData("1"); //pass in state index into getData
            this.Close();
        }

        private void seattle_click2(object sender, RoutedEventArgs e)
        {
            getData("2");
            this.Close();
        }

        private void Spokane3(object sender, RoutedEventArgs e)
        {
            getData("3");
            this.Close();
        }

        private void Kenwick4(object sender, RoutedEventArgs e)
        {
            getData("4");
            this.Close();
        }

        private void Eugene5(object sender, RoutedEventArgs e)
        {
            getData("5");
            this.Close();
        }

        private void Bend6(object sender, RoutedEventArgs e)
        {
            getData("6");
            this.Close();
        }

        private void KFalls7(object sender, RoutedEventArgs e)
        {
            getData("7");
            this.Close();
        }

        private void EOregon8(object sender, RoutedEventArgs e)
        {
            getData("8");
            this.Close();
        }

        private void Wallawalla9(object sender, RoutedEventArgs e)
        {
            getData("9");
            this.Close();
        }

        private void Coast10(object sender, RoutedEventArgs e)
        {
            getData("10");
            this.Close();
        }

        private void JacksonvilleNC11(object sender, RoutedEventArgs e)
        {
            getData("11");
            this.Close();
        }
    }
}
