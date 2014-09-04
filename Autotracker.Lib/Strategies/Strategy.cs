using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class Strategy
    {
        public int BaseNote { get; internal set; }
        public bool[] KeyMask { get; internal set; }
        public int PatSize { get; internal set; }
        public int BlockSize { get; internal set; }
        public bool[] Pats { get; internal set; }
        public int PatId { get; internal set; }
        public float RhythmSpeed { get; internal set; }
        public float Rhythm { get; internal set; }

        public List<IGenerator> Generators { get; set; }

        public Strategy(int baseNote, bool[] keyMask, int patSize, int blockSize)
        {
            var random = new Random();

            BaseNote = baseNote;
            KeyMask = keyMask;
            PatSize = patSize;
            BlockSize = blockSize;

            PatId = 0;
            RhythmSpeed = 2*random.Next(2,3);
            Rhythm = 0.0f;// 2 * random.Next(2, 3);
            // self.rhythm = [3]+[0]*(self.rspeed-1)+[1]+[0]*(self.rspeed-1)
            //self.rhythm *= (self.patsize//len(self.rhythm))

            NewSequence();
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
        public Pattern GetPattern()
        {
            return null;
        }
    }
}
