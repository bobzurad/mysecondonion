using SampleArch.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Data.EntityConfiguration
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration() : base()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.State)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.CreatedBy)
                .HasMaxLength(256);

            Property(p => p.UpdatedBy)
                .HasMaxLength(256);
        }
    }
}
