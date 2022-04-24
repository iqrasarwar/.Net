﻿using Microsoft.Data.SqlClient;

namespace FlouristStudio.Models
{
    public class DataBase
    {
        private static readonly SqlConnection Con = new(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=FloristStudio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static bool RegisterNewUser(SignUp s)
        {
            Con.Open();
            SqlCommand Cmd = new("Insert into [UserBase] (Name,UserName, Password, Email) Values(@name,@username,@password,@email)",Con);
            Cmd.Parameters.Add(new("name", s.Name));
            Cmd.Parameters.Add(new("username", s.UserName));
            Cmd.Parameters.Add(new("password", s.Password));
            Cmd.Parameters.Add(new("email", s.Email));
            int status = Cmd.ExecuteNonQuery();
            Con.Close();
            return status != 0;
        }
    }
}
