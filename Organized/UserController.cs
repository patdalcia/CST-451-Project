using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Organized
{
    public class UserController
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public UserController()
        {
            
        }

    }
}
