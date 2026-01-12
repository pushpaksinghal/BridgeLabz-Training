using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Metal_pipe_cutting
{
    internal interface IPipeOperations
    {
        Pipe[] ReadPipe();
        double FindBestCut(Pipe[] pipes, int requiredLength);
        bool IsCutPossible(Pipe[] pipes, int requiredLength, int[]userCuts);
    }
}
