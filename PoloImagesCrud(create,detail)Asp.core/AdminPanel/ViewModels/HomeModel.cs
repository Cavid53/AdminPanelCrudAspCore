using AdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<RepeatDescription> RepeatDescriptions { get; set; }
        public IEnumerable<Welcome> Welcomes { get; set; }
        public IEnumerable<WhatWeDo> WhatWeDos { get; set; }
        public IEnumerable<Service> Services { get; set; }

    }
}
