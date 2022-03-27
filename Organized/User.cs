using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organized
{
    public class User
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
        public int ID { get; set; }

        public User()
        {

        }
        public User(String F, String L, String U, String EA, int ID)
        {
            this.Firstname = F; 
            this.Lastname = L;
            this.Username = U;
            this.Email = EA;
            this.ID = ID;
        }
    }
}
