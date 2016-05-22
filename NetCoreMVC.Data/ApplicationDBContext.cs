using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NetCoreMVC.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NetCoreMVC.Data
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext()
        {
        }

        public string datacall()
        {
            return "this is called from data Layer";
        }
    }
}
