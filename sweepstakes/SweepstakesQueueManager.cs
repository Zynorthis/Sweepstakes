using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> sweepstakesManager = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesManager.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesManager.Dequeue();
        }
    }
}
