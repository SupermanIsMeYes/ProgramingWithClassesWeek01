using System;
using System.Collections.Generic;

class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction(){
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int topNumberOnly){
        _topNumber = topNumberOnly;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber){
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

     public string GetFractionString()
    {
        string fraction = $"{_topNumber}/{_bottomNumber}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        
        return (double)_topNumber / (double)_bottomNumber;
    }

}