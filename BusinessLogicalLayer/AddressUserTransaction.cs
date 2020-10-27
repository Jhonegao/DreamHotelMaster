using Common;
using DataAccessLayer.Infraestructure;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BusinessLogicalLayer
{
    public class AddressUserTransaction
    {
        public AddressUserTransaction(Address endereco, User usuario)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();
                connection.Open();

                AddressBLL addressBLL = new AddressBLL();

                SingleResponse<int> responseAddressID = addressBLL.Insert(endereco, connection);
                if (responseAddressID.Success)
                {
                    usuario.EnderecoId = responseAddressID.Data;
                    UserBLL userBLL = new UserBLL();
                    Response responseUser = userBLL.Insert(usuario, connection);
                    if (responseUser.Success) {
                        scope.Complete();
                        MessageBox.Show(responseUser.Message);
                    }
                    else
                    {
                        MessageBox.Show(responseUser.Message);
                    }
                }
                else
                {
                    MessageBox.Show(responseAddressID.Message);
                }
                connection.Close();
            }
        }
    }
}

            //SingleResponse<int> responseEnd = enderecoDao.Inserir(endereco);
            //if (responseEnd.Sucess && responseEnd.Data != 0)
            //{
            //    usuario.EnderecoID = responseEnd.Data;
            //    Response response = usuarioDao.Inserir(usuario);
            //    if (response.Sucess) { scope.Complete() }
            //}