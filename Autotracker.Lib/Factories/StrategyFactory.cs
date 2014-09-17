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
        public IRandomInt _randomInt { get; internal set; }
        public IRandomDouble _randomDouble { get; internal set; }
        public IRegistryFactory<IKey, KeyType> _keyFactory { get; internal set; }
        public IRegistryFactory<KeySequenceVariant, KeyType> _keySequenceFactory{get; internal set;}
        public IRegistryFactory<IGenerator, GeneratorType> _generatorFactory{get; internal set;}

        public StrategyFactory(IRandomInt randomInt, 
                               IRandomDouble randomDouble, 
                               IRegistryFactory<IKey, KeyType> keyFactory, 
                               IRegistryFactory<KeySequenceVariant, KeyType> keySequenceFactory)
        {
            _randomInt = randomInt;
            _randomDouble = randomDouble;
            _keyFactory = keyFactory;
            _keySequenceFactory = keySequenceFactory;
        }
        
        public Strategy Get()
        {
            return new Strategy.Builder()
                .WithBaseNote(_randomInt.GetNextRange(50, 50 + 12 - 1) + 12)
                .WithKeyMask((_randomDouble.GetNext() < 0.6) ? _keyFactory.GetByKey(KeyType.Major) : _keyFactory.GetByKey(KeyType.Minor))
                .WithPatternSize(128)
                .WithBlockSize(32)
                .WithPatternId(0)
                .WithRhythm(1.0f) //3]+[0]*(self.rspeed-1)+[1]+[0]*(self.rspeed-1)) * self.patsize//len(self.rhythm)
                .WithRhythmSpeed(2.0f * _randomInt.GetNextRange(2, 3))
                .WithKeySequenceFactory(_keySequenceFactory)
                .Build();
        }
    }
}
