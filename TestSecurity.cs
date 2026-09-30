using System;
using System.Data.SqlClient;

public class TestSecurity
{
    public void GetUser(string userInput)
    {
        string connectionString =
            "Server=localhost;Database=Test;Trusted_Connection=True;";

        using (SqlConnection connection =
               new SqlConnection(connectionString))
        {
            string sql =
                "SELECT * FROM Users WHERE Name = '" + userInput + "'";

            using (SqlCommand command =
                   new SqlCommand(sql, connection))
            {
                command.ExecuteReader();
            }
        }
    }
}
