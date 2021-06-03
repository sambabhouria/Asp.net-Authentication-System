﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Asp.netAuthenticationSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    // In the IdentityUser we have the default colum like {user email, password ...}
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }
      
    }
}
