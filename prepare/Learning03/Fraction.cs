public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() //Constructor
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");

    }

    public Fraction(int _top) //Constructor
    {
        Console.WriteLine("Input a number: ");
        _top = int.Parse(Console.ReadLine());
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int _top, int _bottom) // Constructor
    {
        Console.WriteLine("Input a numerator: ");
        _top = int.Parse(Console.ReadLine());
        Console.WriteLine("Input a denominator: ");
        _bottom = int.Parse(Console.ReadLine());
        Console.WriteLine($"{_top}/{_bottom}");
    }
// Getters and Setters
    public int GetTop()
    {
        return _top;
        
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }    

// Member Functions(Methods)
    public string GetFractionString()
    {

        string frac = $"{_top} / {_bottom}";
        return frac;
    }

    public double GetDecimalValue()
    {
        double frac = _top / _bottom;
        return frac;
    }

}