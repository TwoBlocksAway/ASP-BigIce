using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IceBox.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }

        [ForeignKey("Accont")]
        public string GUID { get; set; }
        [ForeignKey("UserStatus")]
        public int UserStatusId { get; set; }

        public IdentityUser Account { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
