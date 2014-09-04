using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    //http://en.wikipedia.org/wiki/Karplus%E2%80%93Strong_string_synthesis
    public class KarplusStrongSynthSampler : Sampler
    {
        public float Frequency { get; set; }
        public float Decay { get; set; }
        public float NFrequencyMultiply { get; set; }
        public float Filter0 { get; set; }
        public float FilterN { get; set; }
        public float FilterF { get; set; }
        public float FilterDC{ get; set; }
        public float LengthInSeconds { get; set; }
        
        public KarplusStrongSynthSampler(ISamplerConfigurationFactory samplerConfiguration, string name)
            : base(samplerConfiguration, name)
        {
        }
        protected override List<float> GenerateImpl()
        {
            // generate waveform
            var delay = Frequency > 0.0f ? (int)(Definitions._sampleFrequency / Frequency) : 0;
            var noise = new float[delay];

            var nFrequencyCounter = 1.0f;
            var nFrequencyValue = 0.0f;
            var length = (int)(Definitions._sampleFrequency * LengthInSeconds);
            if(length < delay)
            {
                throw new NotSupportedException("KS sample length cannot be less than its period");
            }
            
            // DC filter
            var dq = 0.0f;

            // prefilter with filt0
            var qn = 0.0f;
            var q = 0.0f;

            var volumeCurrent = 1.0f;
            var nVolumeDecay = 1.0f / (Definitions._sampleFrequency * Decay);

            var random = new Random();
            var nlfsr = random.Next(1, 0x7FFF);

            // generate up to "length" samples
            var qf = 0.0f;

            var list = new List<float>();
            var i = 0;
            for (var j = 0; j < length; ++j )
            {
                if (volumeCurrent > 0.0f)
                {
                    if (nFrequencyCounter >= 1.0)
                    {
                        nFrequencyValue = ((nlfsr & 1)!= 0) ? 1.0f : -1.0f;

                        // skip a value to balance it a bit better
                        nlfsr = (nlfsr == 1) ? 0x4000 : nlfsr;

                        if ((nlfsr & 1)!=0)
                        {
                            nlfsr = (nlfsr >> 1) ^ 0x6000;
                        }
                        else
                        {
                            nlfsr >>= 1;
                        }
                        nFrequencyCounter -= 1.0f;
                    }

                    nFrequencyCounter += NFrequencyMultiply;
                    qn = (nFrequencyValue * volumeCurrent - qn) * Filter0 + qn;
                    volumeCurrent -= nVolumeDecay;
                    noise[i] += qn;
                }

                var ov = q = noise[i] = (noise[i] - q) * FilterN + q;
                qf = (ov - qf) * FilterF + qf;
                dq += (qf - dq) * FilterDC;
                list.Add(qf - dq);
                i = (i + 1) % delay;
            }

            var config = Configuration;
            config.LoopEnd = length;
            config.LoopBegin = length - delay;

            return list;
        }
    }
}
