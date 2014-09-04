using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class DrumsGenerator : IGenerator
    {
        public Sampler Kick { get; set; }
        public Sampler Snare { get; set; }
        public Sampler HiHatClosed { get; set; }
        public Sampler HiHatOpen { get; set; }

    }
}
