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
    class CustumerDAO
    {
        public class CustomerDAO
        {
            public Response Insert(Customer customer)
            {
                Response dbResponse = new Response();

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();

                SqlCommand command = new SqlCommand();

                command.CommandText =
                    "INSERT INTO Customer (NOME,CPF,RG,EMAIL,TELFONE1,TELEFONE2,ENDERECOID,ISADMIN,SENHA) VALUES (NOME,CPF,RG,EMAIL,TELFONE1,TELEFONE2,ENDERECOID,SENHA)";
                command.Parameters.AddWithValue("@NOME", customer.Nome);
                command.Parameters.AddWithValue("@CPF", customer.CPF);
                command.Parameters.AddWithValue("@RG", customer.RG);
                command.Parameters.AddWithValue("@EMAIL", customer.Email);
                command.Parameters.AddWithValue("@TELFONE1", customer.Telefones[0]);
                command.Parameters.AddWithValue("@TELFONE2", customer.Telefones[1]);
                command.Parameters.AddWithValue("@ENDERECOID", customer.EnderecoId);
                command.Connection = connection;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    dbResponse.Success = true;
                    dbResponse.Message = "Usario cadastrado com sucesso!";
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

            public Response Update(Customer customer)
            {
                Response dbResponse = new Response();

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();

                SqlCommand command = new SqlCommand();

                command.CommandText =
                    "UPDATE Customer SET NOME = @NOME, ATIVO = @ATIVO WHERE ID = @ID";
                command.Parameters.AddWithValue("@NOME", customer.Nome);
                command.Parameters.AddWithValue("@ATIVO", customer.Ativo);
                command.Parameters.AddWithValue("@ID", customer.ID);


                command.Connection = connection;

                try
                {
                    connection.Open();
                    int nLinhasAfetadas = command.ExecuteNonQuery();
                    if (nLinhasAfetadas != 1)
                    {
                        dbResponse.Success = false;
                        dbResponse.Message = "Registro não encontrado!";
                        return dbResponse;
                    }

                    dbResponse.Success = true;
                    dbResponse.Message = "Customer atualizado com sucesso!";
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

            public Response Delete(Customer customer)
            {
                Response dbResponse = new Response();

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();

                SqlCommand command = new SqlCommand();

                command.CommandText =
                    "DELETE FROM Customer WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", customer.ID);

                command.Connection = connection;

                try
                {
                    connection.Open();
                    int nLinhasAfetadas = command.ExecuteNonQuery();
                    if (nLinhasAfetadas != 1)
                    {
                        dbResponse.Success = false;
                        dbResponse.Message = "Registro não encontrado!";
                        return dbResponse;
                    }

                    dbResponse.Success = true;
                    dbResponse.Message = "Cliente excluído com sucesso!";
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

            public QueryResponse<Customer> GetAll()
            {
                QueryResponse<Customer> response = new QueryResponse<Customer>();
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT * FROM Customers WHERE ATIVO = 1";

                command.Connection = connection;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Customer> customers = new List<Customer>();

                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.ID = (int)reader["ID"];
                        customer.Nome = (string)reader["NOME"];
                        customer.CPF = (string)reader["CPF"];
                        customer.RG = (string)reader["RG"];
                        customer.Telefones[0] = (string)reader["TELEFONE1"];
                        customer.Telefones[1] = (string)reader["TELEFONE2"];
                        customer.Email = (string)reader["EMAIL"];
                        customer.EnderecoId = (int)reader["ENDERECOID"];
                        customer.EnderecoId = (int)reader["ENDERECOID"];
                        customer.Data_Cadastro = (DateTime)reader["DATA_CADASTRO"];
                        customer.Ativo = (bool)reader["ATIVO"];
                        customers.Add(customer);
                    }
                    response.Success = true;
                    response.Message = "Dados selecionados com sucesso.";
                    response.Data = customers;
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "Erro no banco de dados, contate o administrador.";
                    response.ExceptionError = ex.Message;
                    response.StackTrace = ex.StackTrace;
                    return response;
                }
                finally
                {
                    connection.Close();
                }
            }

            public Response IsCpfUnique(string cpf)
            {
                QueryResponse<Customer> response = new QueryResponse<Customer>();

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT ID FROM Customers WHERE CPF = @CPF";
                command.Parameters.AddWithValue("@CPF", cpf);
                command.Connection = connection;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        response.Success = false;
                        response.Message = "CPF já cadastrado.";
                    }
                    else
                    {
                        response.Success = true;
                        response.Message = "CPF único.";
                    }
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "Erro no banco de dados, contate o adm.";
                    response.ExceptionError = ex.Message;
                    response.StackTrace = ex.StackTrace;
                    return response;
                }
                finally
                {
                    connection.Close();
                }
            }

            public SingleResponse<Customer> GetId(Customer customer)
            {
                SingleResponse<Customer> response = new SingleResponse<Customer>();
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT ID FROM Customers WHERE CPF = @CPF";
                command.Parameters.AddWithValue("@CPF", customer.CPF);

                command.Connection = connection;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        customer.ID = (int)reader["ID"];
                    }
                    response.Success = true;
                    response.Message = "Dado selecionado com sucesso.";
                    response.Data = customer;
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "Erro no banco de dados, contate o administrador.";
                    response.ExceptionError = ex.Message;
                    response.StackTrace = ex.StackTrace;
                    return response;
                }
                finally
                {
                    connection.Close();
                }
            }
            public SingleResponse<Customer> GetCpf(Customer customer)
            {
                SingleResponse<Customer> response = new SingleResponse<Customer>();
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT CPF FROM Customers WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", customer.ID);

                command.Connection = connection;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        customer.CPF = (string)reader["CPF"];
                    }

                    response.Success = true;
                    response.Message = "Dado selecionado com sucesso.";
                    response.Data = customer;
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "Erro no banco de dados, contate o administrador.";
                    response.ExceptionError = ex.Message;
                    response.StackTrace = ex.StackTrace;
                    return response;
                }
                finally
                {
                    connection.Close();
                }
            }

        }

    }
}
