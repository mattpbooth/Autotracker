using Autotracker.Lib;
using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.ImpulseTracker.Lib
{
    public class ImpulseTrackerSamplerConfigurationFactory : IFactory<SamplerConfiguration>
    {
        #region Consts
        public const int _flagsDefault = 0;
        public const float _boostDefault = 1.0f;
        public const string _filenameDefault = "AUTOTRKR.BU";
        public const int _globalVolumeDefault = 64;
        public const int _volumeDefault = 64;
        public const int _defaultPanDefault = 32;
        public const int _convertDefault = (int)Convert.Signed;
        public const int _loopBeginDefault = 0;
        public const int _loopEndDefault = 0;
        public const int _frequencyDefault = Definitions._sampleFrequency;
        public const int _sustainBeginDefault = 0;
        public const int _sustainEndDefault = 0;
        public const int _vibrateSpeedDefault = 0;
        public const int _vibrateDepthDefault = 0;
        public const int _vibrateRateDefault = 0;
        public const int _vibrateTypeDefault = 0;
        #endregion

        public SamplerConfiguration Get()
        {
            return new SamplerConfiguration
            {
                 Flags = _flagsDefault,
                 Boost = _boostDefault,
                 Filename = _filenameDefault,
                 GlobalVolume = _globalVolumeDefault,
                 Volume = _volumeDefault,
                 DefaultPan = _defaultPanDefault,
                 Convert = _convertDefault,
                 LoopBegin = _loopBeginDefault,
                 LoopEnd = _loopEndDefault,
                 Frequency = _frequencyDefault,
                 SustainBegin = _sustainBeginDefault,
                 SustainEnd = _sustainEndDefault,
                 VibrateSpeed = _vibrateSpeedDefault,
                 VibrationDepth = _vibrateDepthDefault,
                 VibrationRate = _vibrateRateDefault,
                 VibrationType = _vibrateTypeDefault
            };
        }
    }
}
