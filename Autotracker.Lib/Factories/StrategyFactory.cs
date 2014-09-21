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
        
        private IEnumerable<byte> GenerateRhythm(int rhythmSpeed)
        {
            // Mucky
            var rhythm = new byte[((rhythmSpeed - 1) * 2 ) + 2];

            var idx = 0;
            rhythm[idx++] = 3;
            for(int i=0; i<rhythmSpeed - 1; ++i)
            {
                rhythm[idx++] = 0;
            }
            rhythm[idx++] = 1;
            for(int i=0; i<rhythmSpeed - 1; ++i)
            {
                rhythm[idx++] = 0;
            }

            // Even muckier... this is related to the pattern length
            // Need to kill this blocksize, patternsize dependency at some point...
            var repeat = 128 / rhythmSpeed;

            return Enumerable.Repeat(rhythm, repeat).SelectMany(x => x);
        }

        public Strategy Get()
        {
            // Mucky
            var rhythmSpeed = 2 * _randomInt.GetNextRange(2, 3);
            
            return new Strategy.Builder()
                .WithBaseNote(_randomInt.GetNextRange(50, 50 + 12 - 1) + 12)
                .WithKeyMask((_randomDouble.GetNext() < 0.6) ? _keyFactory.GetByKey(KeyType.Major) : _keyFactory.GetByKey(KeyType.Minor))
                .WithBlockSize(32)
                .WithRhythm(GenerateRhythm(rhythmSpeed))
                .WithRhythmSpeed(rhythmSpeed)
                .WithKeySequenceFactory(_keySequenceFactory)
                .WithKeyFactory(_keyFactory)
                .Build();
        }
    }
}
