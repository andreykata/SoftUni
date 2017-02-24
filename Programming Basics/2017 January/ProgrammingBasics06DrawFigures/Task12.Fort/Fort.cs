using System;
class Fort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        // Draw first line
        int towerLenght = n / 2;
        int betweenTowers = (2 * n) - (2 * towerLenght) - 4;
        string firstLine = "/" + new string('^', towerLenght) + "\\"
            + new string('_', betweenTowers) + "/" 
            + new string('^', towerLenght) + "\\";

        Console.WriteLine(firstLine);
        //Console.WriteLine("{0} {1}", firstLine, firstLine.Length);

        // Draw middle 
        for (int row = 0; row < n - 3; row++)
        {
            string line = "|" + new string(' ', (2 * n) - 2) + "|";
            Console.WriteLine(line);
            //Console.WriteLine("{0} {1}", line, line.Length);
        }

        // Draw second to last line
        string beforeLastLine = "|" + new string(' ', towerLenght + 1)
            + new string('_', betweenTowers) + new string(' ', towerLenght + 1) + "|";

        Console.WriteLine(beforeLastLine);
        //Console.WriteLine("{0} {1}", beforeLastLine, beforeLastLine.Length);

        // Draw last line
        string lastLine = "\\" + new string('_', towerLenght) + "/"
            + new string(' ', betweenTowers) + "\\" 
            + new string('_', towerLenght) + "/";

        Console.WriteLine(lastLine);
        //Console.WriteLine("{0} {1}", lastLine, lastLine.Length);
    }
}
