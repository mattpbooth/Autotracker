using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public abstract class Sampler
    {
        public SamplerConfiguration Configuration{get;internal set;}
        public string Name{get;internal set;} 

        public Sampler(ISamplerConfigurationFactory samplerConfiguration, string name)
        {
            Configuration = samplerConfiguration.Get();
            Name = Name;
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

        public void Amplify()
        {

        }

        protected abstract List<float> GenerateImpl();
    }
}
