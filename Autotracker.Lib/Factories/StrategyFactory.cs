using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public static class StrategyFactory: IFactory<Strategy>
    {
        static public IRandom<int> _randomInt { get; set; }
        static public IRandom<double> _randomDouble { get; set; }

        static public Strategy Get()
        {
            return Strategy.Builder
                .WithBaseNote(_randomInt.GetNextRange(50, 50 + 12 - 1) + 12)
                .WithKeyMask(_randomDouble.GetNext() < 0.6) ? KeyMasks.Minor : KeyMasks.Major)
                .WithPatSize(128)
                .WithBlockSize(32)
                .WithPatId(0)
                .WithRhythm(1.0f);//3]+[0]*(self.rspeed-1)+[1]+[0]*(self.rspeed-1)) * self.patsize//len(self.rhythm)
                .WithRhythmSpeed(2.0f * randomInt.GetNextRange(2,3))
                .Build();
        }
    }
}
