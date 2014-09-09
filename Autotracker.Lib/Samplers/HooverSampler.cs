using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class HooverSampler : Sampler
    {
        protected override List<float> GenerateImpl()
        {
            throw new NotImplementedException();
        }

        public override Sampler Clone()
        {
            return (Sampler)MemberwiseClone();
        }
    }
}
