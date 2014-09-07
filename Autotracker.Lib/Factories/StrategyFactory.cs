using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class StrategyFactory: IFactory<Strategy>
    {
        public IRandom<int> _randomInt { get; set; }
        public IRandom<double> _randomDouble { get; set; }
        public IKey _majorKey { get; set; }
        public IKey _minorKey { get; set; }

        public Strategy Get()
        {
            return new Strategy.Builder()
                .WithBaseNote(_randomInt.GetNextRange(50, 50 + 12 - 1) + 12)
                .WithKeyMask((_randomDouble.GetNext() < 0.6) ? _majorKey : _minorKey)
                .WithPatSize(128)
                .WithBlockSize(32)
                .WithPatId(0)
                .WithRhythm(1.0f) //3]+[0]*(self.rspeed-1)+[1]+[0]*(self.rspeed-1)) * self.patsize//len(self.rhythm)
                .WithRhythmSpeed(2.0f * _randomInt.GetNextRange(2, 3))
                .Build();
        }
    }
}
