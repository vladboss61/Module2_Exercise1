using System;

namespace ClassExample;


public record Sum(int a, int b, int c);


public class User
{
    public int Id { get; set; }

    protected int Name { get; set; }
}

public class CustomUser : User
{
    public string[] Permissions { get; set; }
}

public class Admin : User
{
    public Admin()
    {
        var s = new Sum(10, 20, 30);
    }

    public string[] Permissions { get; set; }
}

public class SpecificAdmin : Admin
{
    public string SpecificName { get; set; }
}



public struct Monster
{
    private int x;
    private int y;

    public Monster()
    {
        x = 10;
        y = 20;
    }
}

enum YesNo
{
    Yes,
    No
}

class Box
{
    internal int _size;

    public int _weight;

    public string _color;

    public bool _isOpen;

    public Item[] Items { get; set; }

    public string _name;
    public string Name
    {
        get => _name;
        set => this._name = value;
    }

    public Box()
    {
        _size = 100;
    }

    public Box(int size)
    {
        _size = size;
    }

    public Box(int size, string color)
        : this(size)
    {
        _size = size;
        _color = color;
        _isOpen = true;
        Name = "Big box";
    }

    public Box AddSize(int size)
    {
        this._size = size;
        Display(this);
        return this;
    }

    public Box AddWeight(int weight)
    {
        this._weight = weight;
        Display(this);
        return this;
    }


    public void Display(Box box)
    {
        box.MethodDisplay();
    }

    public void MethodDisplay()
    {
        Console.WriteLine($"Box: {this._color} / {this._isOpen} / {this._size} / {this._weight}");
    }
}
