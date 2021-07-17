using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System;
using System.Linq;

namespace PlanetaTest.Models
{
    public class ClientsManager
    {

        public static ClientsList GetClientsFromDb(long Identifer)
        {
            try
            {
                using (SqlConnection connection = new(DbInfo.SqlConnectionString))
                {
                    var Result = connection.Query<Client, Subnet, Client>(DbInfo.SqlClientsSelect,
                        (client, subnet) =>
                        {
                            client.Subnet = subnet;
                            return client;
                        },
                        new { Identifer = $"{Identifer}" },
                        splitOn: "IdSubnet").Distinct().ToList();
                    ClientsList clients = new(Result);
                    return clients;
                }
            }
            catch(Exception)
            {
                ClientsList list = new(null);
                return list;
            }
        }
        public static string UpdateSubnetOnClient(long Identifer,int? IdSubnet)
        {
            try
            {
                string sql = DbInfo.SqlClientUpdateSubnet;
                if (IdSubnet == null) //Если не указан номер подсети, то тогда в бд запишется NULL
                    sql = DbInfo.SqlClientUpdateNullSubnet;

                using (SqlConnection connection = new(DbInfo.SqlConnectionString))
                {
                    int NumRowAffected = connection.Execute(sql, new
                    {
                        Identifer = Identifer,
                        IdSubnet = IdSubnet
                    });
                    if (NumRowAffected > 0) return "true";
                    else return "Wrong data";
                }
            }
            catch (Exception e) {
                return e.Message;
            }
        }
	}
}