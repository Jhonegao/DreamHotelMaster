using BusinessLogicalLayer.Checkers;
using Common;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class UserBLL : BaseValidator<User>
    {
        private UserDAO userDAO = new UserDAO();
        public Response Insert(User item, SqlConnection connection)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                return userDAO.Insert(item, connection);
            }
            return response;
        }
        public override Response Validate(User item)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos do endereco devem ser informados");
            }
            foreach (string err in CheckAttributeLength.AttributeLength<User>(item))
            {
                AddError(err);
            }
            AddError(item.Cpf.IsValidCPF());
            AddError(item.Email.IsValidEmail());
            return base.Validate(item);
        }
    }
}
