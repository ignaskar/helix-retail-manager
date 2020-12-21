using System.Collections.Generic;
using HRMDataManager.Library.Internal.DataAccess;
using HRMDataManager.Library.Models;

namespace HRMDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new {Id = id};
            
            return sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "HRMData");
        }
    }
}
