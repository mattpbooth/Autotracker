using Autotracker.Lib.Interfaces;
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
        public float Decay { get; internal set; }
        public float FrequencyMultiply { get; internal set; }
        public float Filter0 { get; internal set; }
        public float FilterN { get; internal set; }
        public float FilterF { get; internal set; }
        public float FilterDC{ get; internal set; }
        public float LengthInSeconds { get; internal set; }
        
        public class KarplusStrongSynthSamplerBuilder : Sampler.Builder
        {
            private float _decay;
            private float _frequencyMultiply;
            private float _filter0;
            private float _filterN;
            private float _filterF;
            private float _filterDC;
            private float _lengthInSeconds;

            public KarplusStrongSynthSamplerBuilder WithDecay(float decay)
            {
                _decay = decay;
                return this;
            }

            public KarplusStrongSynthSamplerBuilder WithFrequencyMultiply(float frequencyMultiply)
            {
                _frequencyMultiply = frequencyMultiply;
                return this;
            }

            public KarplusStrongSynthSamplerBuilder WithFilter0(float filter0)
            {
                _filter0 = filter0;
                return this;
            }

            public KarplusStrongSynthSamplerBuilder WithFilterN(float filterN)
            {
                _filterN = filterN;
                return this;
            }

            public KarplusStrongSynthSamplerBuilder WithFilterF(float filterF)
            {
                _filterF = filterF;
                return this;
            }

            public KarplusStrongSynthSamplerBuilder WithFilterDC(float filterDC)
            {
                _filterDC = filterDC;
                return this;
            }

            public KarplusStrongSynthSamplerBuilder WithLengthInSeconds(float lengthInSeconds)
            {
                _lengthInSeconds = lengthInSeconds;
                return this;
            }

            protected override Sampler BuildImpl()
            {
                return new KarplusStrongSynthSampler
                {
                    Decay = _decay,
                    FrequencyMultiply = _frequencyMultiply,
                    Filter0 = _filter0,
                    FilterN = _filterN,
                    FilterF = _filterF,
                    FilterDC = _filterDC,
                    LengthInSeconds = _lengthInSeconds
                };
            }
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

                    nFrequencyCounter += FrequencyMultiply;
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

            LoopEnd = length;
            LoopBegin = length - delay;

            return list;
        }

        public override Sampler Clone()
        {
            return (Sampler)MemberwiseClone();
        }
    }
}
