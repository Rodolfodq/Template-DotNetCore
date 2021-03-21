using AngularTemplate.Data.Context;
using AngularTemplate.Domain.Entities;
using AngularTemplate.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTemplate.Data.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(AngularTemplateContext context) : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }

    }
}
