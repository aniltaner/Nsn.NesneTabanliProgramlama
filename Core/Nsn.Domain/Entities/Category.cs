using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nsn.Domain.Common;

namespace Nsn.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }

        public Category(string name, int subCategoryId, int sort)
        {
            Name = name;
            SubCategoryId = subCategoryId;
            Sort = sort;
        }

        public required string Name { get; set; }

        public required int SubCategoryId { get; set; }

        public required int Sort { get; set; }
    }



}