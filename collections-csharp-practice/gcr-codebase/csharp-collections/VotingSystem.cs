using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections
{
    internal class VotingSystem
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();
            SortedDictionary<string, int> sortedResults;
            List<string> voteOrder = new List<string>();

            CastVote("Alice");
            CastVote("Bob");
            CastVote("Alice");

            void CastVote(string candidate)
            {
                voteOrder.Add(candidate);
                votes[candidate] = votes.ContainsKey(candidate) ? votes[candidate] + 1 : 1;
            }

            sortedResults = new SortedDictionary<string, int>(votes);

            Console.WriteLine("Sorted Results:");
            foreach (var v in sortedResults)
                Console.WriteLine(v.Key+" : "+v.Value);
        }
    }

}
