using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public class BankRepository
    {
        private string connectionString =
@"Server=.;
Database=BankDB;
Trusted_Connection=True;";
    
    private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public void Add(BankAccount account)
        {
            SqlConnection con=GetConnection();
            con.Open();
            con.Close();
            string query = @"insert into BanckAccounts(AccountNumber,Owner,Balance)
             values(@AccountNumber,@Owner,@Balance)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
            cmd.Parameters.AddWithValue("@Owner", account.Owner);
            cmd.Parameters.AddWithValue("@Balance", account.Balance);
            cmd.ExecuteNonQuery();
        }
        public List<BankAccount> GetAll()
        {
            List<BankAccount> accounts = new List<BankAccount>();

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM BankAccounts";

                SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

            }
            }
            return accounts;
        }







    }
}

