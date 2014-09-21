using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class BassGenerator : SingleSamplerGenerator
    {
        public BassGenerator(ISampler sampler)
            : base(sampler)
        {

        }

        public override void ApplyNotes(IPattern pattern, IStrategy strategy, IKey chord)
        {
            var baseNote = chord.BaseNote;
            var leadIn = 0;
            var blockSize = strategy.BlockSize;
            var rhythm = strategy.Rhythm;

            // TODO: Only fills out first block currently
            for(int i = 0 ; i < blockSize; ++i)
            {
                //if(rhythm)
            }


            //var rhythm = strategy.Rhythm;
            //var key = strategy.Key;
            //var baseNote = key.BaseNote;

            //var leadIn = 0;
            //for(int i = 0; i < strategy.BlockSize; ++i)
            //{

            //}
            //if rhythm[row]&1:
            //    n = base-12 if random.random() < 0.5 else base
            //    pat.data[row][chn] = [n, self.smp, 255, 0, 0]

            //    if leadin != 0 and random.random() < 0.4:
            //        gran = 2
            //        count = 1

            //        #if random.random() < 0.2:
            //        #   gran = 1

            //        if leadin > gran*2 and random.random() < 0.4:
            //            count += 1
            //            if leadin > gran*3 and random.random() < 0.4:
            //                count += 1

            //        for j in xrange(count):
            //            pat.data[row-(j+1)*gran][chn] = [
            //                 base+12 if random.random() < 0.5 else base
            //                ,self.smp
            //                ,0xFF
            //                ,ord('S')-ord('A')+1
            //                ,0xC0 + random.randint(1,2)
            //            ]

            //    if random.random() < 0.2:
            //        pat.data[row][chn][0] += 12
            //        if random.random() < 0.4:
            //            pat.data[row][chn][3] = ord('S')-ord('A')+1
            //            pat.data[row][chn][4] = 0xC0 + random.randint(1,2)
            //        else:
            //            pat.data[row+2][chn] = [254, self.smp, 255, 0, 0]

            //    leadin = 0
            //else:
            //    leadin += 1
        }

        public override IGenerator Clone()
        {
            return (Generator)MemberwiseClone();
        }
    }
}
