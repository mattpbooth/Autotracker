using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class KickerSampler : Sampler
    {
        //public KickerSampler(IFactory<SamplerConfiguration> samplerConfiguration, string name)
        //    : base(samplerConfiguration, name)
        //{
        //}

        // Sampler
        protected override List<float> GenerateImpl()
        {
            var volumeNoise = 0.8f;
            var volumeSine = 1.2f;
            var volumeNoiseDecay = 1.0f / (Definitions._sampleFrequency * 0.01f);
            var qNoise = 0.0f;

            var kickMultiply = (float)Math.PI * 2.0f * 150.0f / Definitions._sampleFrequency;
            var offsetSine = 0.0f;
            var offsetSineSpeed = kickMultiply;
            var offsetSineDecay = 0.9995f;

            var length = (int)(Definitions._sampleFrequency * 0.25f);
            var list = new List<float>();
            for (int i = 0; i < length; ++i)
            {
                var sv = (float)Math.Max(-0.7f, Math.Min(0.7f, Math.Sin(offsetSine)));
                offsetSine += offsetSineSpeed;
                offsetSineSpeed *= offsetSineDecay;

                var random = new Random();
                var nv = ((float)random.NextDouble()*2.0f-1.0f);
                qNoise += (nv - qNoise) * 0.1f;
                nv = qNoise;

                list.Add(nv * volumeNoise + sv * volumeSine);
                volumeNoise -= volumeNoiseDecay;
                volumeNoise = Math.Max(0.0f, volumeNoise);
                
                volumeSine -= offsetSineDecay;
                volumeSine = Math.Max(0.0f, volumeSine);

            }
            return list;
        }
    }
}
