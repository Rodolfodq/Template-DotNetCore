﻿using AngularTemplate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTemplate.Domain.Entities
{
    public class User : Entity
    {        
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
