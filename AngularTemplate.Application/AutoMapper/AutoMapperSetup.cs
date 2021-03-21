using AngularTemplate.Application.ViewModel;
using AngularTemplate.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTemplate.Application.AutoMapper
{
    public class AutoMapperSetup: Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<UserViewModel, User>();

            #endregion

            #region DomainToViewModel
            
            CreateMap<User, UserViewModel>();

            #endregion
        }
    }
}
