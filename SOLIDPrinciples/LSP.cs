// Abstract class Shape is the base class for Rectangle and Square classes.
// The GetArea method is abstract in the base class and is implemented in the derived classes
public abstract class Shape
{
    public abstract int GetArea();
}
// The Rectangle and Square classes are derived from the Shape class and implement the GetArea method
// The Rectangle and Square classes are substitutable for the Shape class
// Rectangle class follows LSP
public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea()
    {
        return Width * Height;
    }
}

// Square class follows LSP
public class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}