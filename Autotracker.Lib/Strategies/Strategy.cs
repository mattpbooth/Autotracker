using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class Strategy : IStrategy
    {
        public int BaseNote { get; internal set; }
        public bool[] KeyMask { get; internal set; }
        public int PatSize { get; internal set; }
        public int BlockSize { get; internal set; }
        public float RhythmSpeed { get; internal set; }
        public float Rhythm { get; internal set; }
        public int PatId { get; internal set; }
        public List<IGenerator> Generators { get; internal set; }

        public bool[] Pats { get; set; }

        public class Builder : IBuilder<Strategy>
        {
            private int _baseNote;
            private bool[] _keyMask;
            private int _blockSize;
            private bool[] _pats;
            private int _patId;
            private float _rhythmSpeed;
            private float _rhythm;

            public Builder WithBaseNote(int baseNote)
            {
                _baseNote = baseNote;
                return this;
            }

            public Builder WithKeyMask(bool[] keyMask)
            {
                _keyMask = keyMask;
                return this;
            }

            public Builder WithBlockSize(int blockSize)
            {
                _blockSize = blockSize;
                return this;
            }

            public Builder WithPats(bool[] pats)
            {
                _pats = pats;
                return this;
            }

            public Builder WithPatId(int patId)
            {
                _patId = patId;
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

            Strategy Get()
            {
                return new Strategy
                {
                    BaseNote = _baseNote,
                    KeyMask = _keyMask,
                    BlockSize = _blockSize,
                    PatId = _patId,
                    Pats = _pats,
                    Rhythm = _rhythm,
                    RhythmSpeed = _rhythmSpeed,
                    Generators = new List<IGenerator>()
                };
            }
        }

        public void NewSequence()
        {
        //    self.kseq = random.choice({
        //    Key_Minor: [
        //        [(0,Key_Minor),(-4,Key_Major),(5,Key_Major),(-2,Key_Major)],
        //        [(0,Key_Minor),(-2,Key_Major),(-4,Key_Major),(-5,Key_Minor)],
        //    ],
        //    Key_Major: [
        //        [(0,Key_Major),(-5,Key_Major),(-3,Key_Minor),(5,Key_Major)],
        //        [(0,Key_Major),(0,Key_Major),(-7,Key_Minor),(-5,Key_Major)],
        //    ],
        //}[self.keytype])

        //self.kseq2 = random.choice({
        //    Key_Minor: [
        //        [(3,Key_Major),(0,Key_Minor),(-4,Key_Major),(-2,Key_Major)],
        //        [(-4,Key_Major),(-2,Key_Major),(0,Key_Minor),(-2,Key_Major)],
        //    ],
        //    Key_Major: [
        //        [(2,Key_Minor),(0,Key_Major),(-3,Key_Minor),(0,Key_Major)],
        //        [(-3,Key_Minor),(-5,Key_Major),(-7,Key_Major),(-5,Key_Major)],
        //    ],
        //}[self.keytype])
        }
        void GeneratePattern(IPattern pattern)
        {}

        void AddGenerator(IGenerator generator)
        {
            Generators.Add(generator);
        }
    }
}
