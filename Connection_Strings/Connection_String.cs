﻿namespace Connection_Strings
{//USE it FOR SQL CONNNECTION OBJECT
    /// <summary>
    /// an example
    /// sqlconnection x=new sqlconnection(Connection_String.Value)
    /// </summary>
    public class Connection_String
    {
        public static string Value = MS;//Change Value When You Want To Change The Connection Strin Wich Fits Your PC 
        private static string MS = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\SAHM\Khayaal_SAHM\DataBase\Restaurant_Cafe.mdf;Integrated Security = True; Connect Timeout = 30";
        private static string HS = @"";//Hossam Enter Your Connection String
        private static string AG = @"";//Ghareeb Enter Your Connection String
        private static string KS = @"";//khaled Enter Your Connection String
        private static string AR = @"";//Aml Enter Your Connection String
    }

}
