using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iman_elahy_hw09.Models
{
    public class Memberrepository
   {
        public static List<Member> ListUser = new List<Member>();
        public void AddMember()
        {

        }
    //    private const string connectionString = "Server=DESKTOP-BJ7SRVH;Database=MemberDB;user id=sa;password=123456;MultipleActiveResultSets=True;TrustServerCertificate=True";


        //    public void AddMember(string Name, string lastName, int NationalCode, int levelendex, string phonenumber, int genderendex)
        //    {


        //        using (SqlConnection cn = new SqlConnection(connectionString))
        //        {
        //            try
        //            {
        //                cn.Open();
        //                string query = "INSERT INTO [dbo].[User](Name,LastName,RegistrationDate,NationalCode,Level,Phonenumber,Gender)VALUES(@Name,@LastName,@RegistrationDate,@NationalCode,@Level,@Phonenumber,@Gender)";

        //                using (SqlCommand cmd = new SqlCommand(query, cn))
        //                {
        //                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
        //                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
        //                    cmd.Parameters.Add("@RegistrationDate", SqlDbType.DateTime2).Value = DateTime.Now;
        //                    cmd.Parameters.Add("@NationalCode", SqlDbType.VarChar).Value = NationalCode;
        //                    cmd.Parameters.Add("@Level", SqlDbType.Char).Value = levelendex;
        //                    cmd.Parameters.Add("@Phonenumber", SqlDbType.VarChar).Value = phonenumber;
        //                    cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = genderendex;

        //                    var result = cmd.ExecuteNonQuery();

        //                }
        //                cn.Close();
        //                Console.WriteLine($"The New Student Inserted");
        //            }
        //            catch (Exception ex)
        //            {

        //                throw ex;
        //            }
        //            finally
        //            {
        //                cn.Close();
        //            }
        //        }

        //    }
        //    public List<Member> GetAllUser()
        //    {
        //        var query = "Select * from dbo.User";
        //        using (SqlConnection cn = new SqlConnection(connectionString))
        //        {
        //            var result = cn.Query<Member>(query).ToList();
        //            return result;
        //        }

        //    }
    }
}
