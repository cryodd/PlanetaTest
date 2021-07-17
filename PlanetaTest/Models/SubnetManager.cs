using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System;
using System.Linq;

namespace PlanetaTest.Models
{
    public class SubnetsManager
    {

        public static Exception InsertIntoSubnet(string IpAddress, int Mask)
        {
            try
            {
                using (SqlConnection connection = new(DbInfo.SqlConnectionString))
                {
                    connection.Execute(DbInfo.SqlSubnetInsert, new { IpAddress = IpAddress, Mask = Mask });
                    return null;
                }
            }
            catch (Exception e)
            {
                return e;
            }
        }
        public static (string IpAddress, int Mask) GetIP(string StringIp)
        {
            try
            {
                if(!Validation.IpStringValidadtion(StringIp)) return("", 0);
                var ConcatString = StringIp.Split(new char[] {'/', '%'}); //Разбивает IpAddress на две строки, символ % присутствует как разделитель т.к. в запросах символ '/' передается как "%2F"
                ConcatString[1] = ConcatString[1].Replace("2F", ""); //Удаляет 2F из маски
                var res = (ConcatString[0], Convert.ToInt32(ConcatString[1]));
                return res;
            }
            catch(Exception)
            {
                return ("",0);
            }
        }
	}
}