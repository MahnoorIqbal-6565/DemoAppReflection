using System;
using Microsoft.Data.SqlClient;

namespace DemoAppReflection
{
    public class SampleClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SampleClass()
        {
            
        }

        public void LoadData(int id)
        {
            string connectionString = "Server=.; Password=sa1234; Database=Employee; Trusted_Connection=True; Encrypt=True; TrustServerCertificate=True"; 
            string query = "SELECT* FROM Users WHERE Id = @id";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = reader.GetInt32(0);
                            Name = reader.GetString(1);
                        }
                    }
                }
            }
        }

        public string GetData()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
