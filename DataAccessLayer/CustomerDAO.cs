using Common;
using DataAccessLayer.Infraestructure;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        public Response Insert(Customer customer)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Customers (NOME, CPF, RG, EMAIL, TELEFONE1, TELEFONE2, ENDERECOID) VALUES (@NOME, @CPF, @RG, @EMAIL, @TELEFONE1, @TELEFONE2, @ENDERECOID)";
            command.Parameters.AddWithValue("@NOME", customer.Nome);
            command.Parameters.AddWithValue("@CPF", customer.CPF);
            command.Parameters.AddWithValue("@RG", customer.RG);
            command.Parameters.AddWithValue("@EMAIL", customer.Email);
            command.Parameters.AddWithValue("@TELEFONE1", customer.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", customer.Telefone_aux);
            command.Parameters.AddWithValue("@ENDERECOID", customer.EnderecoId);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Cliente cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                dbResponse.Success = false;
                dbResponse.Message = "Erro no banco de dados, contate o administrador.";

                dbResponse.StackTrace = ex.StackTrace;
                dbResponse.ExceptionError = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return dbResponse;
        }
    }
}
