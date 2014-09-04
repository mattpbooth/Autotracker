using Autotracker.Lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.ImpulseTracker.Lib
{
    public class ImpulseTrackerPattern : Pattern
    {
        private const int _modPlugMinRows = 4;
        private const int _impulseTrackerMaxRows = 200;
        private const int _impulseTrackerBars = 64;

        private const byte _impulseTrackerDefaultNote = 0xFD;
        private const byte _impulseTracerDefaultInstrument = 0;
        private const byte _impulseTracerDefaultVolume = 0xFF;
        private const byte _impulseTracerDefaultEffectType = 0;
        private const byte _impulseTracerDefaultEffectParameter = 0;

        private struct ImpulseTrackerStruct
        {
            public byte Note{get;set;}
            public byte Instrument{get;set;}
            public byte Volume{get;set;}
            public byte EffectType{get;set;}
            public byte EffectParameter{get;set;}

        }
        public ImpulseTrackerPattern(int rows) : base(rows)
        {
            Debug.Assert(rows >= _modPlugMinRows, "Too few rows");
            Debug.Assert(rows <= _impulseTrackerMaxRows, "Too many rows");

            var trackerStruct = new ImpulseTrackerStruct
            {
                Note = _impulseTrackerDefaultNote,
                Instrument = _impulseTracerDefaultInstrument,
                Volume = _impulseTracerDefaultVolume,
                EffectType = _impulseTracerDefaultEffectType,
                EffectParameter = _impulseTracerDefaultEffectParameter
            };
        }
    }
}
