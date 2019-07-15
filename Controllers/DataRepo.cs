using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class DataRepo
    {
        private readonly Dictionary<int, User> _data =
          new Dictionary<int, User>
            {
                { 5, new User
                    {
                        ID = 5,
                        FirstName = "Gene",
                        LastName = "Robinson",
                        Password = "animals",
                        Email = "generobinson@gmail.com"
                    }}
          };

        public User Get(int id)
        {
            if (_data.TryGetValue(id, out var employee))
            {
                return employee;
            }

            return null;
        }

        public void Add(User employee)
        {
            var id = _data.Keys.Max() + 1;
            _data[id] = employee;
        }

        public void Save(int id, User employee)
        {
            _data[id] = employee;
        }
    }
}
