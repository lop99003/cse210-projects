public class Fraction
{
    //STEP 3 The should have two attributes for the top and bottom numbers 
    private int _top;
    private int _bottom;

    //STEP 4 Create the following constructors: no parameters that 
    //intializes the number to 1/1 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    //one parameter for the top and that initializes the denominator 
    //to 1. So that if you pass in the number 5, the fraction would 
    //be intialized 5/1 
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    // two parameters, one for the top and one for the bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //STEP 5 Create getters and setters for both the top and the 
    //bottom values.
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom ()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //can call all of these methods and get the correct values, 
    //using setters to change the values and then getters to 
    //retrieve these new values and then display them to the 
    //console.
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return(double)_top / _bottom;
    }



}