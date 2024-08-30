using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerCleanArchitecture.Domain.Common.Entities
{
    public class Stadium : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int? Capacity { get; set; }
    }
}
