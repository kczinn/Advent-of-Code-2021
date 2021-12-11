public class Day2bAnswer {
    public void Run() {
        var lines = System.IO.File.ReadAllLines(@"./Day2/input.txt");

        var sumForward = 0;
        var aim = 0;
        var depth = 0;


        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains("forward")){
                var forward = int.Parse(lines[i].Split(' ')[1]);
                sumForward = sumForward + forward;
                depth = depth + (aim * forward);
            }
            if (lines[i].Contains("down")){
                aim = aim + int.Parse(lines[i].Split(' ')[1]);
            }
            if (lines[i].Contains("up")){
                aim = aim - int.Parse(lines[i].Split(' ')[1]);
            }
        }
        Console.WriteLine("Final Horizontal: " + sumForward);
        Console.WriteLine("Final Depth: " + depth);
        Console.WriteLine("Final Solution: " + sumForward * depth);
    }
}


