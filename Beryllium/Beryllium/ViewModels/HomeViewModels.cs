
using Beryllium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.ViewModels
{
    public class HomeViewModels
    {
        public List<SliderItem> sliderItems { get; set; }
        public List<SmallSlider> smallSliders { get; set; }
        public List<News> news { get; set; }
        public List<Testimonials> testimonials { get; set; }
        public List<IconTextArea> iconTextAreas { get; set; }
    }
}
