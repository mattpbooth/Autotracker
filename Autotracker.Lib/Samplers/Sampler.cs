using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public abstract class Sampler : ISampler, IPrototype<Sampler>
    {
        public string Name { get; internal set; }
        public int Flags { get; internal set; }
        public float Boost { get; internal set; }
        public string Filename { get; internal set; }
        public int GlobalVolume { get; internal set; }
        public int Volume { get; internal set; }
        public int DefaultPan { get; internal set; }
        public int Convert { get; internal set; }
        public int LoopBegin { get; internal set; }
        public int LoopEnd { get; internal set; }
        public float Frequency { get; internal set; }
        public int SustainBegin { get; internal set; }
        public int SustainEnd { get; internal set; }
        public int VibrateSpeed { get; internal set; }
        public int VibrationDepth { get; internal set; }
        public int VibrationRate { get; internal set; }
        public int VibrationType { get; internal set; }

        public abstract class Builder : IBuilder<Sampler>
        {
            private string _name;
            private int _flags;
            private float _boost;
            private string _filename;
            private int _globalVolume;
            private int _volume;
            private int _defaultPan;
            private int _convert;
            private int _loopBegin;
            private int _loopEnd;
            private float _frequency;
            private int _sustainBegin;
            private int _sustainEnd;
            private int _vibrateSpeed;
            private int _vibrationDepth;
            private int _vibrationRate;
            private int _vibrationType;

            public Builder WithName(string name)
            {
                _name = name;
                return this;
            }

            public Builder WithFlags(int flags)
            {
                _flags = flags;
                return this;
            }

            public Builder WithBoost(float boost)
            {
                _boost = boost;
                return this;
            }

            public Builder WithFilename(string filename)
            {
                _filename = filename;
                return this;
            }

            public Builder WithGlobalVolume(int globalVolume)
            {
                _globalVolume = globalVolume;
                return this;
            }

            public Builder WithVolume(int volume)
            {
                _volume = volume;
                return this;
            }

            public Builder WithDefaultPan(int defaultPan)
            {
                _defaultPan = defaultPan;
                return this;
            }

            public Builder WithConvert(int convert)
            {
                _convert = convert;
                return this;
            }

            public Builder WithLoopBegin(int loopBegin)
            {
                _loopBegin = loopBegin;
                return this;
            }

            public Builder WithLoopEnd(int loopEnd)
            {
                _loopEnd = loopEnd;
                return this;
            }

            public Builder WithFrequency(float frequency)
            {
                _frequency = frequency;
                return this;
            }

            public Builder WithSustainBegin(int sustainBegin)
            {
                _sustainBegin = sustainBegin;
                return this;
            }

            public Builder WithSustainEnd(int sustainEnd)
            {
                _sustainEnd = sustainEnd;
                return this;
            }

            public Builder WithVibrateSpeed(int vibrateSpeed)
            {
                _vibrateSpeed = vibrateSpeed;
                return this;
            }

            public Builder WithVibrationDepth(int vibrationDepth)
            {
                _vibrationDepth = vibrationDepth;
                return this;
            }

            public Builder WithVibrationRate(int vibrationRate)
            {
                _vibrationRate = vibrationRate;
                return this;
            }

            public Builder WithVibrationType(int vibrationType)
            {
                _vibrationType = vibrationType;
                return this;
            }

            public Sampler Build()
            {
                // Build the sampler in derived class, then apply the builder changes.
                var builtSampler = BuildImpl();

                builtSampler.Name = _name;
                builtSampler.Flags= _flags;
                builtSampler.Boost= _boost;
                builtSampler.Filename = _filename;
                builtSampler.GlobalVolume = _globalVolume;
                builtSampler.Volume = _volume;
                builtSampler.DefaultPan = _defaultPan;
                builtSampler.Convert = _convert;
                builtSampler.LoopBegin = _loopBegin;
                builtSampler.LoopEnd = _loopEnd;
                builtSampler.Frequency = _frequency;
                builtSampler.SustainBegin = _sustainBegin;
                builtSampler.SustainEnd = _sustainEnd;
                builtSampler.VibrateSpeed = _vibrateSpeed;
                builtSampler.VibrationDepth = _vibrationDepth;
                builtSampler.VibrationRate = _vibrationRate;
                builtSampler.VibrationType = _vibrationType;

                return builtSampler;
            }

            protected abstract Sampler BuildImpl();
        }

        public bool Generate()
        {
            var generatedList = GenerateImpl();
            if (generatedList != null)
            {
                Amplify();
                return true;
            }
            return false;
        }

        public abstract Sampler Clone();

        public void Amplify()
        {

        }

        protected abstract List<float> GenerateImpl();
    }
}
