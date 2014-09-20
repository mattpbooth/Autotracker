using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class NoiseHitSampler : Sampler
    {
        public float Decay{get; set;}
        public float FilterL{get; set;}
        public float FilterH { get;  set; }

        public class NoiseHitSamplerBuilder : Sampler.Builder
        {
            public float _decay { get; internal set; }
            public float _filterL { get; internal set; }
            public float _filterH { get; internal set; }

            public NoiseHitSamplerBuilder WithDecay(float decay)
            {
                _decay = decay;
                return this;
            }

            public NoiseHitSamplerBuilder WithFilterL(float filterL)
            {
                _filterL = filterL;
                return this;
            }

            public NoiseHitSamplerBuilder WithFilterH(float filterH)
            {
                _filterH = filterH;
                return this;
            }

            protected override Sampler BuildImpl()
            {
                return new NoiseHitSampler
                {
                    Decay = _decay,
                    FilterL = _filterL,
                    FilterH = _filterH
                };
            }
        }

        // Sampler
        protected override List<float> GenerateImpl()
        {
            var volumeNoise = 1.0f;
            var volumeNoiseDecay = 1.0 / (Definitions._sampleFrequency * Decay);

            var ql = 0.0f;
            var qh = 0.0f;

            var length = (int)(Definitions._sampleFrequency * Decay);
            List<float> list = new List<float>();

            for(int i = 0; i < length; ++i)
            {
                var random = new Random();
                var nv = ((float)random.NextDouble()*2.0f-1.0f);
                ql += (nv - ql) * FilterL;
                qh += (nv - qh) * FilterH;
                nv = ql - qh;

                list.Add(nv * volumeNoise);
                volumeNoise = (float)Math.Max(0.0f, volumeNoise - volumeNoiseDecay);
            }
            return list;
        }

        public override ISampler Clone()
        {
            return (Sampler)MemberwiseClone();
        }
    }
}
