using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nsn.Domain.Common;

namespace Nsn.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail()
        {

        }

        public Detail(string title, string value, int categoryId)
        {
            Title = title;
            Value = value;
            CategoryId = categoryId;
        }
        public required string Title { get; set; }

        public string Value { get; set; }

        public required int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}