using Company444.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Company444.DAL.Data.Configrations
{
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //fluent api  for "Department" Domain

            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.Code).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(D => D.Name).HasColumnType("varchar").IsRequired();



        }
    }
}
