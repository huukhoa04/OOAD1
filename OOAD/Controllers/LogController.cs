using Microsoft.EntityFrameworkCore;
using OOAD.Data;
using OOAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.Controllers
{
    public class LogController
    {
        public readonly OoadContext _context;
        public LogController()
        {
            _context = new OoadContext();
        }
        public User LoginCheck(LoginModel loginModel)
        {
            var usercheck = _context.Users.SingleOrDefault(x => x.UsernameLog == loginModel.username && x.Password == loginModel.password);
            return usercheck;
        }
        public bool Register(RegisterModel registerModel)
        {
            var usercheck = _context.Users.SingleOrDefault(x => x.UsernameLog == registerModel.logUsername);
            if (usercheck == null)
            {
                User user = new User
                {
                    Userid = _context.Users.Count(),
                    UsernameLog = registerModel.logUsername,
                    Username = registerModel.Username,
                    Password = registerModel.logPassword,
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
