using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class DrumsGenerator : Generator
    {
        public Sampler Kick { get; set; }
        public Sampler Snare { get; set; }
        public Sampler HiHatClosed { get; set; }
        public Sampler HiHatOpen { get; set; }

        public override void ApplyNotes(IPattern pattern, IStrategy strategy)
        {

        }

        public override Generator Clone()
        {
            return (Generator)MemberwiseClone();
        }
    }
}
