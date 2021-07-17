using System;
using System.Data.SqlClient;

namespace PlanetaTest.Models
{
    public struct DbInfo
    {
        public const string SqlConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlanetaTest;integrated Security=True";
        public const string SqlClientsSelect = "select * from Clients left join Subnets on Clients.IdSubnet = Subnets.IdSubnet where Identifer = @Identifer";
        public const string SqlSubnetInsert = "insert into Subnets values(@IpAddress,@Mask)";
        public const string SqlClientUpdateSubnet = "update Clients set IdSubnet = @IdSubnet where Identifer = @Identifer";
        public const string SqlClientUpdateNullSubnet = "update Clients set IdSubnet = NULL where Identifer = @Identifer";
    }
}