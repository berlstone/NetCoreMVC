using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore;
using NetCoreMVC.Data;
using NetCoreMVC.Model;

namespace NetCoreMVC.Service
{
    public class Service
    {
        public Service()
        {
        }
        public string datacall()
        {
            //var obj = new ApplicationDBContext();
            //return obj.datacall();
            return "";
        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    // Add framework services.
        //    services.AddDbContext<ApplicationDbContext>(options =>
        //        options.UseSqlServer(Microsoft.EntityFrameworkCore.Scaffolding.Internal.Configuration.GetConnectionString("DefaultConnection")));

        //    services.AddIdentity<ApplicationUser, IdentityRole>()
        //        .AddEntityFrameworkStores<ApplicationDbContext>()
        //        .AddDefaultTokenProviders();
        //}
    }

}
