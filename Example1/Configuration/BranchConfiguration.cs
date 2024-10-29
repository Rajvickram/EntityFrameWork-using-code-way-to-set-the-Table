using Example1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1.Configuration
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
                new Branch
                {
                    Id = 4,
                    Name = "Palani",
                    Location = "CDM",
                    PhoneNo = 9345046803
                },
                new Branch
                {
                    Id = 5,
                    Name = "Selvi",
                    Location = "CDM",
                    PhoneNo = 9385836573
                },
                new Branch
                {
                    Id = 6,
                    Name = "BNM",
                    Location = "Chennai",
                    PhoneNo = 7010986623
                }
                );
        }
    }
}
