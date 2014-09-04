using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public abstract class Tracker
    {
        public List<Sampler> Samplers { get; set; }
        public string Name { get; set; }

        private struct PatternPlaylistEntry
        {
            public Pattern Pattern { get; set; }
            public int Order { get; set; }
        }

        private List<PatternPlaylistEntry> _patternPlayList = new List<PatternPlaylistEntry>();

        public void AddPattern(Strategy strategy)
        {
            _patternPlayList.Add(new PatternPlaylistEntry { Pattern = strategy.GetPattern(), Order = _patternPlayList.Count });
        }

        public abstract void Save();
    }
}
