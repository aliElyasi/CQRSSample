using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSSample.Data;

namespace CQRSSample.Application.Services
{
     public class UserService{
       private List<User> users =new List<User>(){
        new User(Guid.NewGuid(),"James"),
        new User(Guid.NewGuid(),"alex"),
        new User(Guid.NewGuid(),"william"),
       };

       public List<User> GetUsers()=>users;
       public void AddUsers(User user)=>users.Add(user);

    }
}