using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Company.Entities
{
    public class JobConfiguration:EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
            Property(i => i.Name)
                             .HasColumnName("Name")
                             .IsRequired();

            HasMany(i => i.Employees)
              .WithRequired(i => i.Job)
              .HasForeignKey(i => i.JobID);
        }
    }
}
