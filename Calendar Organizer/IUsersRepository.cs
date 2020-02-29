using Calendar_Organizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar_Organizer
{
    public interface IUsersRepository
    {
        public IEnumerable<Admin> GetAdmins();
        public IEnumerable<Guest> GetGuests();

    }
}
