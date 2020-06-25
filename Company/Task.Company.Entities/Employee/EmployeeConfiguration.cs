using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Company.Entities
{
    public class EmployeeConfiguration :EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            Property(i => i.Name)
              .HasColumnName("Name")
              .HasMaxLength(250)
              .IsRequired();

            Property(i => i.Email)
                          .HasColumnName("Email")
                          .IsRequired();


            Property(i => i.Gender)
                          .HasColumnName("Gender")
                          .IsRequired();

            Property(i => i.Mobile)
                          .HasColumnName("Mobile")
                          .IsRequired();

            Property(i => i.NationalID)
                          .HasColumnName("NationalID")
                          .IsRequired();

            Property(i => i.Status)
                         .HasColumnName("Status")
                         .IsRequired();


            Property(i => i.HiringDate)
                       .HasColumnName("HiringDate");

            HasRequired(i => i.Job)
              .WithMany(i => i.Employees)
              .HasForeignKey(i => i.JobID);

        }

    }
}
