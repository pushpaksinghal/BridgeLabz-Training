using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Metal_pipe_cutting
{
    internal class utility:IPipeOperations
    {
        public Pipe[] ReadPipe()
        {
            Pipe[] pipes = new Pipe[5];
            for (int i = 0; i < pipes.Length; i++)
            {
                Console.WriteLine("Enter the length of pipe:");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price of pipe:");
                double price = Convert.ToDouble(Console.ReadLine());
                pipes[i] = new Pipe(length,price);
            }
            return pipes;
        }

        public double FindBestCut(Pipe[] pipes, int rodLength)
        {
            double[] dp = new double[rodLength + 1];

            for (int len = 1; len <= rodLength; len++)
            {
                double max = 0;

                for (int i = 0; i < pipes.Length; i++)
                {
                    if (pipes[i].length <= len)
                    {
                        double candidate =
                            pipes[i].price + dp[len - pipes[i].length];

                        if (candidate > max)
                            max = candidate;
                    }
                }

                dp[len] = max;
            }

            return dp[rodLength];
        }

        public bool IsCutPossible(Pipe[] pipes, int rodLength, int[] userCuts)
        {
            int totalLength = 0;

            foreach (int cut in userCuts)
            {
                bool exists = false;

                foreach (Pipe p in pipes)
                {
                    if (p.length == cut)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                    return false;

                totalLength += cut;
            }

            return totalLength <= rodLength;
        }
    }
}
