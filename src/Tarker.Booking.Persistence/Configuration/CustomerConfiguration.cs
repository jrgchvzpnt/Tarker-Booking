using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Customer;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Persistence.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entityBuilder)
        {
            entityBuilder.HasKey(e => e.CustomerId);
            entityBuilder.Property(e => e.FullName).IsRequired();
            entityBuilder.Property(e => e.DocumentNumber).IsRequired();

            entityBuilder.HasMany(x => x.Bookings)
                .WithOne(x => x.Customer).
                HasForeignKey(x => x.CustumerId);
        }
    }
}
