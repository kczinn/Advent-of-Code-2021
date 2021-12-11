public class Day3aAnswer {
    public void Run() {
        var lines = System.IO.File.ReadAllLines(@"./Day3/input3.txt");

        var gammarate = "";
        var epsilonrate = "";
        var columnA = "";
        var columnB = "";
        var columnC = "";
        var columnD = "";
        var columnE = "";
        var columnF = "";
        var columnG = "";
        var columnH = "";
        var columnI = "";
        var columnJ = "";
        var columnK = "";
        var columnL = "";



        for (int i = 0; i < lines.Length; i++)
        {

            columnA = columnA + lines[i][0];
            columnB = columnB + lines[i][1];
            columnC = columnC + lines[i][2];
            columnD = columnD + lines[i][3];
            columnE = columnE + lines[i][4];
            columnF = columnF + lines[i][5];
            columnG = columnG + lines[i][6];
            columnH = columnH + lines[i][7];
            columnI = columnI + lines[i][8];
            columnJ = columnJ + lines[i][9];
            columnK = columnK + lines[i][10];
            columnL = columnL + lines[i][11];
            
        }
        if(columnA.Count(f => f == '1') > columnA.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }


 if(columnB.Count(f => f == '1') > columnB.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }


 if(columnC.Count(f => f == '1') > columnC.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }



 if(columnD.Count(f => f == '1') > columnD.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }


 if(columnE.Count(f => f == '1') > columnE.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }

 if(columnF.Count(f => f == '1') > columnF.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }


 if(columnG.Count(f => f == '1') > columnG.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }


 if(columnH.Count(f => f == '1') > columnH.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }

 if(columnI.Count(f => f == '1') > columnI.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }

 if(columnJ.Count(f => f == '1') > columnJ.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }

 if(columnK.Count(f => f == '1') > columnK.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }

 if(columnL.Count(f => f == '1') > columnL.Count(f => f == '0')){
            gammarate = gammarate + "1";
            epsilonrate = epsilonrate + "0";
        }
        else{
            gammarate = gammarate + "0";
            epsilonrate = epsilonrate + "1";
        }

var GR = Convert.ToInt32(gammarate, 2);
var ER = Convert.ToInt32(epsilonrate, 2);

        Console.WriteLine("Final Gamma Rate: " + GR);
        Console.WriteLine("Final Epsilon Rate: " + ER);
        Console.WriteLine("Final Power Consumption: " + GR * ER);
    }
}


