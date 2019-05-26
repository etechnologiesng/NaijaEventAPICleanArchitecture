using Microsoft.Extensions.DependencyInjection;
using NaijaEvent.Domain.Entities;
using NaijaEvent.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaijaEvent.Service
{
    public static class DBInitiializer
    {

      
            public static void Initialize(IServiceProvider serviceProvider)
            {
                var context = serviceProvider.GetRequiredService<NaijaEventContext>();
                context.Database.EnsureCreated();
                if (!context.NEvents.Any())
                {
                    context.NEvents.Add(new NEvent() { EventId = new Guid(), EventName = "hello", Description = "red.css", EndDate = new DateTime(4/4/2017 ), StartDate = new DateTime(4 / 4 / 2017) });
                  //  context.Tenants.Add(new Tenant() { Name = "Sample", Host = "sample", Style = "blue.css" });
                    context.SaveChanges();
                }
            
        }
    }
}
