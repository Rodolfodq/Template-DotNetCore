using AngularTemplate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTemplate.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
       
    }
}
