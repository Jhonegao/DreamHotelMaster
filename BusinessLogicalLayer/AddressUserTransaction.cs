using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class AddressUserTransaction
    {
        public AddressUserTransaction(Address endereco, User usuario)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                AddressBLL addressBLL = new AddressBLL();
                UserBLL userBLL = new UserBLL();
                if (addressBLL.Insert(endereco).Success)
                {
                    Response response = userBLL.Insert(usuario);
                    if (response.Success) { scope.Complete(); }
                }
            }
            //SingleResponse<int> responseEnd = enderecoDao.Inserir(endereco);
            //if (responseEnd.Sucess && responseEnd.Data != 0)
            //{
            //    usuario.EnderecoID = responseEnd.Data;
            //    Response response = usuarioDao.Inserir(usuario);
            //    if (response.Sucess) { scope.Complete() }
            //}
        }
    }
}
