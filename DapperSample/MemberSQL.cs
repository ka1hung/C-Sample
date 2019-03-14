using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace DapperSample
{
    public class MemberSQL
    {
        string strConnection = "";
        public MemberSQL(string Host, string DB, string User, string Password)
        {
            strConnection = string.Format("server = {0}; database = {1}; uid = {2}; pwd = {3}; Connect Timeout=1;", Host, DB, User, Password);
        }
        //select
        public List<MemberInfo> GetMemberInfo()
        {
            //Query MemberInfo
            List<MemberInfo> results = null;
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                string strSql = "SELECT [Seq],[Email],[Name],[LineID],[Valid],[AuthTime] FROM[mydb].[dbo].[MemberInfo]";
                results = conn.Query<MemberInfo>(strSql).ToList();
            }
            return results;
        }
        //insert
        public bool InsertMemberInfo(MemberInfo member)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                string strSql = "INSERT INTO MemberInfo(Email,Name,LineID,Valid,AuthTime) VALUES (@Email,@Name,@LineID,@Valid,@AuthTime);";
                var result = conn.Execute(strSql, member);
                if (result == 1)
                    return true;
            }
            return false;
        }

        //delete
        public bool DeleteMemberInfo(int seq)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                string strSql = "DELETE MemberInfo WHERE seq = " + seq.ToString();

                var result = conn.Execute(strSql);
                if (result == 1)
                    return true;
            }
            return false;
        }
        //update
        public bool UpdateMemberInfo(int seq)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                string strSql = "UPDATE MemberInfo SET Email = 'kevin@leegood.com.tw' WHERE seq = " + seq.ToString();
                var result = conn.Execute(strSql);
                if (result == 1)
                    return true;
            }
            return false;
        }
        //Create Table123
        public bool CreateMemberInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    string strSql = @"CREATE TABLE MemberInfo
                                (
                                [Seq] [bigint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
                                [Email] [nchar] (100) NULL,
                                [Name] [nchar] (100) NULL,
                                [LineID] [nchar] (100) NULL,
                                [Valid] [nchar] (10) NULL,
                                [AuthTime] [datetime] NULL
                                 )";

                    conn.Execute(strSql);

                    return true;
                }
            }
            catch { return false; }

        }
    }

    public class MemberInfo
    {
        public Int64 Seq { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LineID { get; set; }
        public string Valid { get; set; }
        public DateTime AuthTime { get; set; }

        public override string ToString()
        {
            return Seq.ToString().Trim() + "\t" + Email.Trim() + "\t" + Name.Trim() + "\t" + LineID.Trim() + "\t" + Valid.Trim() + "\t" + AuthTime.ToString().Trim();
        }
    }

}
