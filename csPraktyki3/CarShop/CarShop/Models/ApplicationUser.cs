﻿using Microsoft.AspNetCore.Identity;

namespace CarShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
