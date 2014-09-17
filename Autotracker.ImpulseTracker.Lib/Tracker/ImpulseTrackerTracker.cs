using Autotracker.Lib;
using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.ImpulseTracker.Lib
{
    /// <summary>
    /// Tracker concrete type - ImpulseTracker.
    /// http://www.users.on.net/~jtlim/ImpulseTracker/ 
    /// </summary>
    public class ImpulseTrackerTracker : ITracker
    {
        ITracker _trackerDecoratee;

        public ImpulseTrackerTracker(ITracker trackerDecoratee)
        {
            _trackerDecoratee = trackerDecoratee;
        }

        public void Generate()
        {
            _trackerDecoratee.Generate();
             
            // TODO: Tracker Generation Wizardry
        }
    }
}
