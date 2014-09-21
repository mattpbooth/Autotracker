using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class AmbientMelodyGenerator : SingleSamplerGenerator
    {
        public AmbientMelodyGenerator(ISampler sampler)
            : base(sampler)
        {

        }

        public override void ApplyNotes(IPattern pattern, IStrategy strategy, IKey chord)
        {

        }

        public override IGenerator Clone()
        {
            return (Generator)MemberwiseClone();
        }
    }
}
