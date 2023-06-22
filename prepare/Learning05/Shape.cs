// See the comment below about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
public class Shape
{
    private double error = 0;
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public virtual string GetColor()
    {
        return _color;
    }

    public virtual void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
      return error;
    }
}