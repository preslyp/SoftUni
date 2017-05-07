using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Building
{
    private string adress; //полета
    private int floors;
    private double sizeInSquareMeters;

    public string Adress //пропърти - има два параметър вземи стойност и подмени стойност
    {
        get
        {
            return this.adress;
        }

    } 

    public int Floors
    {
        get
        {
            return this.floors;
        }
    }

    public double SizeInSquareMeters
    {
        get
        {
            return this.sizeInSquareMeters;
        }
    }


    public Building(string adress, int floors, double sizeInSquareMeters) //Конструктури. Съвпада с името на класа. 
                                                                          //Неговата задача е да зададе начални стойности на полетата
                                                                          //Moже да има и празни или безпараметърен конструктур
    {
        this.adress = adress;
        this.floors = floors;
        this.sizeInSquareMeters = sizeInSquareMeters;
    }
    
    public Building(string adress) : this(adress, 0, 0.0) { }
    public override string ToString()
    {
        return String.Format("Adress: {0}; Floors: {1}; Size: {2}", this.adress, this.floors, this.sizeInSquareMeters);
    }
}

public class PlayWithBulidibgs
{
    static void Main()
    {
        Building softUni = new Building("15-17 Tintiava", 3, 1450.12 );
        Building parkHotelMoskow = new Building("10 z. . Iztok", 12, 12000.99);
        Building pancherebo = new Building("fdfdf");
        Console.WriteLine(softUni);
        Console.WriteLine(parkHotelMoskow);
        Console.WriteLine(pancherebo);
    }
}

