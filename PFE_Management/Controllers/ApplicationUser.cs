using Microsoft.AspNetCore.Identity;
using System;

namespace PFE_Management.Controllers
{
    internal class ApplicationUser
    {
        public static implicit operator ApplicationUser(IdentityUser v)
        {
            throw new NotImplementedException();
        }
    }
}