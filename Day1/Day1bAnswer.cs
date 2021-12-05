public class Day1bAnswer {
    public void Run() {
        var lines = System.IO.File.ReadAllLines(@"./Day1/1a.txt");

        var numDecreased = 0;
        var numEqual = 0;
        var numIncreased = 0;


        for (int i = 0; i < lines.Length - 2; i++)
        {
            
            if(i==0){
                Console.WriteLine(" (N/A - no previous sum)");
                continue;
            }
            
            var n0 = int.Parse(lines[i]);
            var n1 = int.Parse(lines[i+1]);
            var n2 = int.Parse(lines[i+2]);
            var currentSum = n0 + n1 + n2;

            var m0 = int.Parse(lines[i]);
            var m1 = int.Parse(lines[i+1]);
            var m2 = int.Parse(lines[i-1]);
            var priorSum = m0 + m1 + m2;
            

            if(priorSum > currentSum) {
                Console.WriteLine(currentSum + " (decreased)");
                numDecreased++;
                continue;
            }
            if(priorSum == currentSum) {
                Console.WriteLine(currentSum + " (equal)");
                numEqual++;
                continue;
            }
            if(priorSum < currentSum) {
                Console.WriteLine(currentSum + " (increased)");
                numIncreased++;
                continue;
            }   
        }
        Console.WriteLine("Total Increased: " + numIncreased);
        Console.WriteLine("Total Decreased: " + numDecreased);
        Console.WriteLine("Total Equal: " + numEqual);
    }
}


