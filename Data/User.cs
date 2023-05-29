using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSSample.Data
{
    public class User
    {
        public User(Guid id , string name)
        {
            this.id = id;
            this.name = name;
        }

        public Guid id { get; set; }
        public string name { get; set; }
        

    
    }




}