using Calendar_Organizer.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar_Organizer
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbConnection _conn;
        public UsersRepository(IDbConnection conn)
        {
            this._conn = conn;
        }
        public IEnumerable<Admin> GetAdmins()
        {
            return _conn.Query<Admin>("SELECT * FROM admin;");
        }
        public IEnumerable<Guest> GetGuests()
        {
            return _conn.Query<Guest>("SELECT * FROM guest;");
        }
    }
}
