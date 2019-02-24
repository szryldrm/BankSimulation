using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAssig4
{

    class Jobs
    {
        private int times;
        private String job;

        Random rnd = new Random();

        public Jobs(String Job)
        {
            job = Job;
            times = rnd.Next(1, 10);
        }

        public Jobs()
        {
            
        }

        public int Time
        {
            get {
                return times;
            }

            set {
                times = value;
            }
        }

        public string Job
        {
            get {
                return job;
            }

            set {
                job = value;
            }
        }
    }
}
