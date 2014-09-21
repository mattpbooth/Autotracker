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
        public int BaseNote { get; set; }
        public IKey Key { get; set; }
        public int BlockSize { get; set; }
        public int RhythmSpeed { get; set; }
        public IEnumerable<byte> Rhythm { get; set; }

        public IRegistryFactory<IKey, KeyType> KeyFactory { get; internal set; }
        public IRegistryFactory<KeySequenceVariant, KeyType> KeySequenceFactory { get; internal set; }

        public class Builder : IBuilder<Strategy>
        {
            private int _baseNote;
            private IKey _key;
            private int _blockSize;
            private int _rhythmSpeed;
            private IEnumerable<byte> _rhythm;
            private IRegistryFactory<IKey, KeyType> _keyFactory;
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

            public Builder WithBlockSize(int blockSize)
            {
                _blockSize = blockSize;
                return this;
            }

            public Builder WithRhythmSpeed(int rhythmSpeed)
            {
                _rhythmSpeed = rhythmSpeed;
                return this;
            }

            public Builder WithRhythm(IEnumerable<byte> rhythm)
            {
                _rhythm = rhythm;
                return this;
            }

            public Builder WithKeyFactory(IRegistryFactory<IKey, KeyType> keyFactory)
            {
                _keyFactory = keyFactory;
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
                    Rhythm = _rhythm,
                    RhythmSpeed = _rhythmSpeed,
                    KeyFactory = _keyFactory,
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

            //var sequence = (pattern.Id % 8 >= 4) 
            var sequence = KeySequenceFactory.GetByKey(Key.KeyType);

            for (int i = 0; i < pattern.Size; i += BlockSize)
            {
                // Create a new key from the sequence relative to our base note
                var currentKeySequence = sequence.KeySequence.Pop();

                var chord = KeyFactory.GetByKey(currentKeySequence.KeyType);
                chord.BaseNote = BaseNote + currentKeySequence.Note;
                
                foreach (var g in generators)
                {
                    g.ApplyNotes(pattern, this, chord);
                }
            }
            return true;
        }
    }
}
