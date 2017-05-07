using System;

class FourFactors
{
    static void Main(string[] args)
    {
        //input
        double fG = double.Parse(Console.ReadLine());
        double fGA = double.Parse(Console.ReadLine());
        double pointFG = double.Parse(Console.ReadLine());
        double turnOv = double.Parse(Console.ReadLine());
        double offReb = double.Parse(Console.ReadLine());
        double oppDRB = double.Parse(Console.ReadLine());
        double freeT = double.Parse(Console.ReadLine());
        double freeTA = double.Parse(Console.ReadLine());

        double eFG, tOV, oRB, fT;

        //logic

        eFG = (fG + 0.5 * pointFG) / fGA;
        tOV = turnOv / (fGA + 0.44 * freeTA + turnOv);
        oRB = offReb / (offReb + oppDRB);
        fT = freeT / fGA;

        //output
        Console.WriteLine("eFG% {0:F3}", eFG);
        Console.WriteLine("TOV% {0:F3}", tOV);
        Console.WriteLine("ORB% {0:F3}", oRB);
        Console.WriteLine("FT% {0:F3}", fT);

       
    }
}
