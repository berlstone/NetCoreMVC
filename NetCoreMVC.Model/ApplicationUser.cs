using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NetCoreMVC.Model
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            DateCreated = DateTime.Now;
        }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicUrl { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public bool Activated { get; set; }

        public int RoleId { get; set; }

        //public virtual ICollection<Goal> Goals { get; set; }

        //public virtual ICollection<FollowUser> FollowFromUser { get; set; }

        //public virtual ICollection<FollowUser> FollowToUser { get; set; }

        //public virtual ICollection<GroupRequest> GroupRequests { get; set; }

        public string DisplayName
        {
            get { return FirstName + " " + LastName; }
        }


    }
}
