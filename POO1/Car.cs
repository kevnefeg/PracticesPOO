using System;

public class Car
{
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
        int gallons =0;
        Console.Write("How many Gallons would you like? ");
        gallons = Int32.Parse(Console.ReadLine());

    }

    public void km()
    {

    }

    public void remaininggasoline()
    {

    }
}