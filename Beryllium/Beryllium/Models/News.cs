using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class News : BaseEntity
    {
        public string PostDate { get; set; }
        public string PostName { get; set; }
        public string PostText { get; set; }


    }
}
