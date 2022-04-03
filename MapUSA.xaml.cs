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


                    // Maximum power that charge control system must be able to handle based on array size.
                    // I sent this to a hidden text box on mainWindow
                    _mainWindow.maxInstPower1KW_Textblock.Text = reader[13].ToString();
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

        private void Charlotte12(object sender, RoutedEventArgs e)
        {
            getData("12");
            this.Close();
        }

        private void Asheville13(object sender, RoutedEventArgs e)
        {
            getData("13");
            this.Close();
        }

        private void Raleigh14(object sender, RoutedEventArgs e)
        {
            getData("14");
            this.Close();
        }

        private void Norfolk15(object sender, RoutedEventArgs e)
        {
            getData("15");
            this.Close();
        }

        private void Richmond16(object sender, RoutedEventArgs e)
        {
            getData("16");
            this.Close();
        }

        private void Roanoke17(object sender, RoutedEventArgs e)
        {
            getData("17");
            this.Close();
        }

        private void VirginiaWestSide18(object sender, RoutedEventArgs e)
        {
            getData("18");
            this.Close();
        }

        private void DC19(object sender, RoutedEventArgs e)
        {
            getData("19");
            this.Close();

        }

        private void Baltimore20(object sender, RoutedEventArgs e)
        {
            getData("20");
            this.Close();
        }

        private void WestMD21(object sender, RoutedEventArgs e)
        {
            getData("21");
            this.Close();
        }

        private void Charleston22(object sender, RoutedEventArgs e)
        {
            getData("22");
            this.Close();
        }

        private void MiddleDW23(object sender, RoutedEventArgs e)
        {
            getData("23");
            this.Close();
        }

        private void MiddleDW24(object sender, RoutedEventArgs e)
        {
            getData("24");
            this.Close();
        }

        private void MiddlePA25(object sender, RoutedEventArgs e)
        {
            getData("25");
            this.Close();
        }

        private void WestPA27(object sender, RoutedEventArgs e)
        {
            getData("27");
            this.Close();
        }

        private void WestPA28(object sender, RoutedEventArgs e)
        {
            getData("28");
            this.Close();
        }

        private void Columbia29(object sender, RoutedEventArgs e)
        {
            getData("29");
            this.Close();
        }

        private void NorthEastSC30(object sender, RoutedEventArgs e)
        {
            getData("30");
            this.Close();
        }

        private void MtZion31(object sender, RoutedEventArgs e)
        {
            getData("31");
            this.Close();
        }

        private void Atlanta32(object sender, RoutedEventArgs e)
        {
            getData("32");
            this.Close();
        }

        private void Douglas33(object sender, RoutedEventArgs e)
        {
            getData("33");
            this.Close();
        }

        private void Tallahassee34(object sender, RoutedEventArgs e)
        {
            getData("34");
            this.Close();
        }

        private void Pensacola35(object sender, RoutedEventArgs e)
        {
            getData("35");
            this.Close();
        }

        private void Gainesville36(object sender, RoutedEventArgs e)
        {
            getData("36");
            this.Close();
        }

        private void Tampa37(object sender, RoutedEventArgs e)
        {
            getData("37");
            this.Close();
        }

        private void Miami38(object sender, RoutedEventArgs e)
        {
            getData("38");
            this.Close();
        }

        private void Enterprise39(object sender, RoutedEventArgs e)
        {
            getData("39");
            this.Close();
        }

        private void WesternMid40(object sender, RoutedEventArgs e)
        {
            getData("40");
            this.Close();
        }

        private void Huntsville41(object sender, RoutedEventArgs e)
        {
            getData("41");
            this.Close();
        }

        private void Knoxville42(object sender, RoutedEventArgs e)
        {
            getData("42");
            this.Close();
        }

        private void Nashville43(object sender, RoutedEventArgs e)
        {
            getData("43");
            this.Close();
        }

        private void WesternMid44(object sender, RoutedEventArgs e)
        {
            getData("44");
            this.Close();
        }

        private void Lexington51(object sender, RoutedEventArgs e)
        {
            getData("51");
            this.Close();
        }

        private void Madisonville52(object sender, RoutedEventArgs e)
        {
            getData("52");
            this.Close();
        }

        private void Cincinnati53(object sender, RoutedEventArgs e)
        {
            getData("53");
            this.Close();
        }

        private void Columbus56(object sender, RoutedEventArgs e)
        {
            getData("56");
            this.Close();
        }

        private void Cleaveland57(object sender, RoutedEventArgs e)
        {
            getData("57");
            this.Close();
        }

        private void MichiganMid58(object sender, RoutedEventArgs e)
        {
            getData("58");
            this.Close();
        }
    }
}
