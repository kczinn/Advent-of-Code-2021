public class Day2aAnswer {
    public void Run() {
        var lines = System.IO.File.ReadAllLines(@"./Day2/input.txt");

        var sumForward = 0;
        var sumDown = 0;
        var sumUp = 0;


        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains("forward")){
                sumForward = sumForward + int.Parse(lines[i].Split(' ')[1]);
            }
            if (lines[i].Contains("down")){
                sumDown = sumDown + int.Parse(lines[i].Split(' ')[1]);
            }
            if (lines[i].Contains("up")){
                sumUp = sumUp + int.Parse(lines[i].Split(' ')[1]);
            }
        }
        Console.WriteLine("Final Horizontal: " + sumForward);
        Console.WriteLine("Final Depth: " + (sumDown - sumUp));
        Console.WriteLine("Final Solution: " + sumForward * (sumDown - sumUp));
    }
}


