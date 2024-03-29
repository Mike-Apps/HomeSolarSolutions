﻿using System;
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
                    _mainWindow.JanInfo.Text = (float.Parse(reader[1].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.FebInfo.Text = (float.Parse(reader[2].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.MarInfo.Text = (float.Parse(reader[3].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.AprInfo.Text = (float.Parse(reader[4].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.MayInfo.Text = (float.Parse(reader[5].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.JunInfo.Text = (float.Parse(reader[6].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.JulInfo.Text = (float.Parse(reader[7].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.AugInfo.Text = (float.Parse(reader[8].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.SepInfo.Text = (float.Parse(reader[9].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.OctInfo.Text = (float.Parse(reader[10].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.NovInfo.Text = (float.Parse(reader[11].ToString()).ToString("N2")) + " W/h";
                    _mainWindow.DecInfo.Text = (float.Parse(reader[12].ToString()).ToString("N2")) + " W/h";
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

        private void IndianaNorthE59(object sender, RoutedEventArgs e)
        {
            getData("59");
            this.Close();
        }

        private void SouthIndiana60(object sender, RoutedEventArgs e)
        {
            getData("60");
            this.Close();
        }

        private void Indianapolis61(object sender, RoutedEventArgs e)
        {
            getData("61");
            this.Close();
        }

        private void Chicago62(object sender, RoutedEventArgs e)
        {
            getData("62");
            this.Close();
        }

        private void Middletown63(object sender, RoutedEventArgs e)
        {
            getData("63");
            this.Close();
        }

        private void Carbondale64(object sender, RoutedEventArgs e)
        {
            getData("64");
            this.Close();
        }

        private void NorthWisconsin65(object sender, RoutedEventArgs e)
        {
            getData("65");
            this.Close();
        }

        private void MidWisconsin66(object sender, RoutedEventArgs e)
        {
            getData("66");
            this.Close();
        }

        private void Milwaukee67(object sender, RoutedEventArgs e)
        {
            getData("67");
            this.Close();
        }

        private void NorthMinnesota68(object sender, RoutedEventArgs e)
        {
            getData("68");
            this.Close();
        }

        private void MidMinnesota69(object sender, RoutedEventArgs e)
        {
            getData("69");
            this.Close();
        }

        private void SouthMinnesota70(object sender, RoutedEventArgs e)
        {
            getData("70");
            this.Close();
        }

        private void CedarRapids71(object sender, RoutedEventArgs e)
        {
            getData("71");
            this.Close();
        }

        private void CedarRapids72(object sender, RoutedEventArgs e)
        {
            getData("72");
            this.Close();
        }

        private void MidIowa73(object sender, RoutedEventArgs e)
        {
            getData("73");
            this.Close();
        }

        private void KansasCity74(object sender, RoutedEventArgs e)
        {
            getData("74");
            this.Close();
        }

        private void SouthMissouri75(object sender, RoutedEventArgs e)
        {
            getData("75");
            this.Close();
        }

        private void Fayetteville76(object sender, RoutedEventArgs e)
        {
            getData("76");
            this.Close();
        }

        private void LittleRock77(object sender, RoutedEventArgs e)
        {
            getData("77");
            this.Close();
        }

        private void NorthMississippi78(object sender, RoutedEventArgs e)
        {
            getData("78");
            this.Close();
        }

        private void MidMississippi79(object sender, RoutedEventArgs e)
        {
            getData("79");
            this.Close();
        }

        private void SouthMississippi81(object sender, RoutedEventArgs e)
        {
            getData("81");
            this.Close();
        }

        private void BatonRouge82(object sender, RoutedEventArgs e)
        {
            getData("82");
            this.Close();
        }

        private void NorthLousiana83(object sender, RoutedEventArgs e)
        {
            getData("83");
            this.Close();
        }

        private void SouthLousiana84(object sender, RoutedEventArgs e)
        {
            getData("84");
            this.Close();
        }

        private void Houston85(object sender, RoutedEventArgs e)
        {
            getData("85");
            this.Close();
        }

        private void SanAntonio86(object sender, RoutedEventArgs e)
        {
            getData("86");
            this.Close();
        }

        private void FtWorth87(object sender, RoutedEventArgs e)
        {
            getData("87");
            this.Close();
        }

        private void Odessa88(object sender, RoutedEventArgs e)
        {
            getData("88");
            this.Close();
        }

        private void Armarillo89(object sender, RoutedEventArgs e)
        {
            getData("89");
            this.Close();
        }

        private void Abiline90(object sender, RoutedEventArgs e)
        {
            getData("90");
            this.Close();
        }

        private void OklahomaPanhandle91(object sender, RoutedEventArgs e)
        {
            getData("91");
            this.Close();
        }

        private void SouthOklahoma92(object sender, RoutedEventArgs e)
        {
            getData("92");
            this.Close();
        }

        private void MidOklahoma93(object sender, RoutedEventArgs e)
        {
            getData("93");
            this.Close();
        }

        private void Whichita94(object sender, RoutedEventArgs e)
        {
            getData("94");
            this.Close();
        }

        private void Topeka95(object sender, RoutedEventArgs e)
        {
            getData("95");
            this.Close();
        }

        private void NWKansas96(object sender, RoutedEventArgs e)
        {
            getData("96");
            this.Close();
        }


        private void Lincoln97(object sender, RoutedEventArgs e)
        {
            getData("97");
            this.Close();
        }

        private void NorthPlatte98(object sender, RoutedEventArgs e)
        {
            getData("98");
            this.Close();
        }

        private void NorthNebraska99(object sender, RoutedEventArgs e)
        {
            getData("99");
            this.Close();
        }

        private void SouixFalls100(object sender, RoutedEventArgs e)
        {
            getData("100");
            this.Close();
        }

        private void Piere101(object sender, RoutedEventArgs e)
        {
            getData("101");
            this.Close();
        }

        private void Piere102(object sender, RoutedEventArgs e)
        {
            getData("102");
            this.Close();
        }

        private void Fargo103(object sender, RoutedEventArgs e)
        {
            getData("103");
            this.Close();
        }

        private void Fargo104(object sender, RoutedEventArgs e)
        {
            getData("104");
            this.Close();
        }

        private void Antler105(object sender, RoutedEventArgs e)
        {
            getData("105");
            this.Close();
        }

        private void Billings106(object sender, RoutedEventArgs e)
        {
            getData("106");
            this.Close();
        }

        private void Billings107(object sender, RoutedEventArgs e)
        {
            getData("10");
            this.Close();
        }

        private void Butte108(object sender, RoutedEventArgs e)
        {
            getData("108");
            this.Close();
        }

        private void NWMontana109(object sender, RoutedEventArgs e)
        {
            getData("109");
            this.Close();
        }

        private void NorthWyoming110(object sender, RoutedEventArgs e)
        {
            getData("110");
            this.Close();
        }

        private void SWWyoming111(object sender, RoutedEventArgs e)
        {
            getData("111");
            this.Close();
        }

        private void SEWyoming112(object sender, RoutedEventArgs e)
        {
            getData("112");
            this.Close();
        }

        private void NWColorado113(object sender, RoutedEventArgs e)
        {
            getData("113");
            this.Close();
        }

        private void Denver114(object sender, RoutedEventArgs e)
        {
            getData("114");
            this.Close();
        }

        private void SWColorado115(object sender, RoutedEventArgs e)
        {
            getData("115");
            this.Close();
        }

        private void SEColorado116(object sender, RoutedEventArgs e)
        {
            getData("116");
            this.Close();
        }

        private void Albuquerque117(object sender, RoutedEventArgs e)
        {
            getData("117");
            this.Close();
        }

        private void SENewMexico118(object sender, RoutedEventArgs e)
        {
            getData("118");
            this.Close();
        }

        private void SWNewMexico119(object sender, RoutedEventArgs e)
        {
            getData("119");
            this.Close();
        }

        private void Pheonix120(object sender, RoutedEventArgs e)
        {
            getData("120");
            this.Close();
        }

        private void Yuma121(object sender, RoutedEventArgs e)
        {
            getData("121");
            this.Close();
        }

        private void NArizona122(object sender, RoutedEventArgs e)
        {
            getData("122");
            this.Close();
        }

        private void SEUtah123(object sender, RoutedEventArgs e)
        {
            getData("123");
            this.Close();
        }

        private void NEUtah124(object sender, RoutedEventArgs e)
        {
            getData("124");
            this.Close();
        }

        private void SaltLakeCity125(object sender, RoutedEventArgs e)
        {
            getData("125");
            this.Close();
        }

        private void SWUtah126(object sender, RoutedEventArgs e)
        {
            getData("126");
            this.Close();
        }

        private void SEIdaho127(object sender, RoutedEventArgs e)
        {
            getData("127");
            this.Close();
        }

        private void SWIdaho128(object sender, RoutedEventArgs e)
        {
            getData("128");
            this.Close();
        }

        private void NIdaho129(object sender, RoutedEventArgs e)
        {
            getData("129");
            this.Close();
        }

        private void NWNevada130(object sender, RoutedEventArgs e)
        {
            getData("130");
            this.Close();
        }

        private void NENevada131(object sender, RoutedEventArgs e)
        {
            getData("131");
            this.Close();
        }

        private void LasVegas132(object sender, RoutedEventArgs e)
        {
            getData("132");
            this.Close();
        }

        private void MidNevada133(object sender, RoutedEventArgs e)
        {
            getData("133");
            this.Close();
        }

        private void SECalifornia134(object sender, RoutedEventArgs e)
        {
            getData("134");
            this.Close();
        }

        private void SanDiego135(object sender, RoutedEventArgs e)
        {
            getData("135");
            this.Close();
        }

        private void SEMidCalifornia136(object sender, RoutedEventArgs e)
        {
            getData("136");
            this.Close();
        }

        private void SanFrancisco137(object sender, RoutedEventArgs e)
        {
            getData("137");
            this.Close();
        }

        private void CalifornianearReno138(object sender, RoutedEventArgs e)
        {
            getData("138");
            this.Close();
        }

        private void SantaBarbra139(object sender, RoutedEventArgs e)
        {
            getData("139");
            this.Close();
        }

        private void Redding140(object sender, RoutedEventArgs e)
        {
            getData("140");
            this.Close();
        }

        private void NWCalifornia141(object sender, RoutedEventArgs e)
        {
            getData("141");
            this.Close();
        }

        private void VerHamp142(object sender, RoutedEventArgs e)
        {
            getData("142");
            this.Close();
        }

        private void RhodeIsland143(object sender, RoutedEventArgs e)
        {
            getData("143");
            this.Close();
        }

        private void RhodeIsland144(object sender, RoutedEventArgs e)
        {
            getData("144");
            this.Close();
        }

        private void NidMontana145(object sender, RoutedEventArgs e)
        {
            getData("145");
            this.Close();
        }

        private void LowerEastMontana146(object sender, RoutedEventArgs e)
        {
            getData("146");
            this.Close();
        }
    }
}
