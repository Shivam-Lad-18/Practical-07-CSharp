public abstract class Shape
{
    public abstract int GetArea();
}

// Step 2: Rectangle class follows LSP
public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea()
    {
        return Width * Height;
    }
}

// Step 3: Square class follows LSP
public class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}