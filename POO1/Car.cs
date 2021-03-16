using System;

public class Car
{
     int gallons =0;
     int kmm =0;
    //attributes
    private string color;
    private string brand;


    //constrcutors

    public Car (string pcolor, string pbrand)
    {
        color = pcolor;
        brand = pbrand;
        Console.Write(color + " ");
        Console.WriteLine(brand);
    }

    //methods

    public void fullgastank()
    {
       
        Console.Write("How many Gallons would you like? ");
        gallons = Int32.Parse(Console.ReadLine());

    }

    public void km()
    {
        
        Console.Write("How many Km had you traveled? ");
        kmm = Int32.Parse(Console.ReadLine());

    }

    public void remaininggasoline()
    {
        double remaininggasoline = 0;
        double tankreamining =0;
        remaininggasoline = kmm*0.25;
        tankreamining = gallons-remaininggasoline;
        Console.Write("Your reamining gasoline is : " + tankreamining);
        


    }
}