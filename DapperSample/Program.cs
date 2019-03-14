using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. create mssql connection object (ip,database,user,password)
            MemberSQL sql = new MemberSQL("192.168.3.195", "mydb", "sa", "leegood");

            //2. create MemberInfo Table
            sql.CreateMemberInfo();

            //3. insert data to MemberInfo Table
            MemberInfo mi = new MemberInfo();
            mi.Email = "leegood@gmail.com";
            mi.Name = "leegood";
            mi.LineID = "ouyr2345jhxcvncc";
            mi.Valid = "not yet";
            mi.AuthTime = DateTime.Now;
            sql.InsertMemberInfo(mi);
            //or insert by object
            sql.InsertMemberInfo(new MemberInfo
            {
                Email = "123@gmail.com",
                Name = "kevin",
                LineID = "23456789qwertyuisdfghj",
                Valid = "OK",
                AuthTime = DateTime.Now
            });

            //4.get all MemberInfo data
            var result = sql.GetMemberInfo();

            Console.WriteLine("Total Number: "+result.Count());
            foreach (var r in result)
            {
                Console.WriteLine(r.ToString());
            }

            Console.Read();
        }
    }
}
