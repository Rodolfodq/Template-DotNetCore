using AngularTemplate.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTemplate.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
        public bool Post(UserViewModel userViewModel);
        UserViewModel GetById(string id);
        bool Put(UserViewModel userViewModel);
    }
}
