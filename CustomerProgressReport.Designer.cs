using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerProgram_L4DC193_
{
    class clsActivity
    {
        private string AName, AM1, AM2, AM3;
        public string ActivityName
        {
            get
            {
                return AName;
            }
            set
            {
                AName = value;
            }
        }

        public string Metric1
        {
            get
            {
                return AM1;
            }
            set
            {
                AM1 = value;
            }
        }

        public string Metric2
        {
            get
            {
                return AM2;
            }
            set
            {
                AM2 = value;
            }
        }

        public string Metric3
        {
            get
            {
                return AM3;
            }
            set
            {
                AM3 = value;
            }
        }
    }
}
