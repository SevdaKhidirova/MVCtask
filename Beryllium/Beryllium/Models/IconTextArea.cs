using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class IconTextArea : BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
    }
}
