using BlazorServerCleanArchitecture.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerCleanArchitecture.Domain.Common
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
