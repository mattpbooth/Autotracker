using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    /// <summary>
    /// The 'auto' in auto tracker.
    /// Composition strategy, uses the generators, base pattern and musical theory to generate harmonic patterns for tracker data.
    /// </summary>
    public class Strategy : IStrategy
    {
        public int BaseNote { get; internal set; }
        public IKey Key { get; internal set; }
        public int PatternSize { get; internal set; }
        public int BlockSize { get; internal set; }
        public float RhythmSpeed { get; internal set; }
        public float Rhythm { get; internal set; }
        public int PatternId { get; internal set; }

        // TODO: DI
        public IRegistryFactory<KeySequenceVariant, KeyType> KeySequenceFactory { get; internal set; }

        public class Builder : IBuilder<Strategy>
        {
            private int _baseNote;
            private IKey _key;
            private int _patternSize;
            private int _blockSize;
            private int _patternId;
            private float _rhythmSpeed;
            private float _rhythm;
            private IRegistryFactory<KeySequenceVariant, KeyType> _keySequenceFactory;

            public Builder WithBaseNote(int baseNote)
            {
                _baseNote = baseNote;
                return this;
            }

            public Builder WithKeyMask(IKey key)
            {
                _key = key;
                return this;
            }

            public Builder WithPatternSize(int patSize)
            {
                _patternSize = patSize;
                return this;
            }

            public Builder WithBlockSize(int blockSize)
            {
                _blockSize = blockSize;
                return this;
            }

            public Builder WithPatternId(int patId)
            {
                _patternId = patId;
                return this;
            }

            public Builder WithRhythmSpeed(float rhythmSpeed)
            {
                _rhythmSpeed = rhythmSpeed;
                return this;
            }

            public Builder WithRhythm(float rhythm)
            {
                _rhythm = rhythm;
                return this;
            }

            public Builder WithKeySequenceFactory(IRegistryFactory<KeySequenceVariant, KeyType> keySequenceFactory)
            {
                _keySequenceFactory = keySequenceFactory;
                return this;
            }

            public Strategy Build()
            {
                return new Strategy
                {
                    BaseNote = _baseNote,
                    Key = _key,
                    BlockSize = _blockSize,
                    PatternId = _patternId,
                    Rhythm = _rhythm,
                    RhythmSpeed = _rhythmSpeed,
                    KeySequenceFactory = _keySequenceFactory
                };
            }
        }
        
        public bool GeneratePattern(IEnumerable<IGenerator> generators, IPattern pattern)
        {
            if (generators.Count() <= 0)
            {
                return false;
            }

            //for (int i = 0; i <= iterations; ++i)
            //{
            //    var sequenceVarient = _keySequenceFactory.Get(Key.KeyType);               

            //    // TODO: Enforce the pattern, block size relationship.
            //    //for(int j = 0; j <= PatternSize; j += BlockSize)
            //    //{
            //      //  var keySequence = sequenceVarient[j / BlockSize];
            //        //k,kt = kseq.pop(0)
            //        //kchord = kt(self.basenote+k)
            //        //for chn,gen in self.gens:
            //        //    gen.apply_notes(chn, pat, self, self.rhythm, i, self.blocksize, self.key, kchord)

            //        //kseq.append(k)
            //    //}
                    

            //    //self.pats.append(pat)
            //    //Patterns.Add(pattern);


            //    //self.pat_idx += 1

            //    //return pat
            //}
            return true;
        }
    }
}
