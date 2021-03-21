using AngularTemplate.Application.Interfaces;
using AngularTemplate.Application.ViewModel;
using AngularTemplate.Domain.Entities;
using AngularTemplate.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTemplate.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public List<UserViewModel> Get()
        {
            List<UserViewModel> _userViewModels = new List<UserViewModel>();
            IEnumerable<User> _users = this.userRepository.GetAll();

            foreach (var item in _users)
            {
                _userViewModels.Add(new UserViewModel { Id = item.Id, Email = item.Email, Name = item.Name });
            }

            return _userViewModels;
        }
    }
}
