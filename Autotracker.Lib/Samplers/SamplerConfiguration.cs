using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public struct SamplerConfiguration
    {
        public string Name {get;set;}
        public int Flags{get;set;}
        public float Boost{get;set;}
        public string Filename{get;set;}
        public int GlobalVolume{get;set;}
        public int Volume{get;set;}
        public int DefaultPan{get;set;}
        public int Convert{get;set;}
        public int LoopBegin{get; set;}
        public int LoopEnd{get; set;}
        public float Frequency{get; set;}
        public int SustainBegin{get;set;}
        public int SustainEnd{get;set;}
        public int VibrateSpeed{get;set;}
        public int VibrationDepth{get;set;}
        public int VibrationRate{get;set;}
        public int VibrationType{get;set;}
    }
}
