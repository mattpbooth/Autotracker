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
        public ISampler Kick { get; internal set; }
        public ISampler Snare { get; internal set; }
        public ISampler HiHatClosed { get; internal set; }
        public ISampler HiHatOpen { get; internal set; }

        public DrumsGenerator(ISampler kickSampler, ISampler snareSampler, ISampler hiHatClosedSampler, ISampler hiHatOpenSampler)
        {
            Kick = kickSampler;
            Snare = snareSampler;
            HiHatClosed = hiHatClosedSampler;
            HiHatOpen = hiHatOpenSampler;
        }
        public override void ApplyNotes(IPattern pattern, IStrategy strategy)
        {

        }

        public override IGenerator Clone()
        {
            return (Generator)MemberwiseClone();
        }
    }
}
