using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nsn.Domain.Entities;

namespace Nsn.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Yemekler",
                    SubCategoryId = 0,
                    Sort = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "İçecekler",
                    SubCategoryId = 0,
                    Sort = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "Tatlılar",
                    SubCategoryId = 0,
                    Sort = 3
                },
                new Category
                {
                    Id = 4,
                    Name = "Pizzalar",
                    SubCategoryId = 1,
                    Sort = 1
                },
                new Category
                {
                    Id = 5,
                    Name = "Burgerler",
                    SubCategoryId = 1,
                    Sort = 2
                }
            );
        }
    }
}
