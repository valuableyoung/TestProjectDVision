using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LetterSending.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController : ControllerBase
    {
     

        public string InsertDataQuery = @"Insert into [SKU_DB].[dbo].[SendingLetter] 
                                                  (Subject, 
                                                  ToPerson,
                                                  Sender,
                                                  LetterBody,
                                                  Date)
                                                       
                                           values (@Subject, @To, @Sender, @LetterBody, @Date) ";


        [HttpPost("setdata")]
        public void SetData([FromBody] DataBaseLetterInfo info)
        {
            var con = new SqlConnection(Config.connectiontring);
            var cmd = new SqlCommand(InsertDataQuery);
            cmd.Parameters.Add("@Subject", SqlDbType.VarChar).Value = info.Subject;
            cmd.Parameters.Add("@To", SqlDbType.VarChar).Value = info.To;
            cmd.Parameters.Add("@Sender", SqlDbType.VarChar).Value = info.Sender;
            cmd.Parameters.Add("@LetterBody", SqlDbType.VarChar).Value = info.LetterBody;
            cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();

            

        }



    }
}
