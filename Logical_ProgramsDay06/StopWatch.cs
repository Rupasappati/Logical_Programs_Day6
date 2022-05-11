using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_ProgramsDay06
{
    public class StopWatch
    {
        
        public void Stop_Watch()
        {
            Console.Write("\n");
            Console.WriteLine("***Simulate Stopwatch Program***");
            Console.Write("\n");


			// Create new stopwatch

			Stopwatch stopwatch = new Stopwatch();

			// Begin timing
			stopwatch.Start();

			
			for (int i = 0; i < 1000; i++)
			{
				Thread.Sleep(1);
			}

			// Stop timing
			stopwatch.Stop();

			// Write result
			Console.WriteLine("Time elapsed: {0}",
				stopwatch.Elapsed);
		}
	}
}

  
