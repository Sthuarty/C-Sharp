using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets {
    class Program {
		static void Main(string[] args) {
		    List<int> alice = new List<int>(new int []{5,6,7});
		    List<int> bob = new List<int>(new int []{3,6,10});
		    
		    
			Console.WriteLine(String.Join(" ", compareTriplets(alice, bob)));
		}
        static List<int> compareTriplets(List<int> a, List<int> b) {
            int totalA = 0;
            int totalB = 0;
            List<int> total = new List<int>();
    
            
    
            for (int i = 0; i < a.Count; i++) {
                if (a[i] > b[i])
                    totalA++;
                if (b[i] > a[i])
                    totalB++;
            }
            
            total.Add(totalA);
            total.Add(totalB);

            return total;
    
        }
    }
}
