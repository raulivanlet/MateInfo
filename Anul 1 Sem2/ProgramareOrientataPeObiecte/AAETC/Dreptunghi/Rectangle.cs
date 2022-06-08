using Problema1;

namespace Dreptunghi;
internal class Rectangle
{
    public Point TopLeft() { get; set; }
    public Point Width() { get; set; }
    public Point Height() { get; set; }

    public Rectangle() { }

    public Rectangle() : this(new Point(0, 0), 0, 0)
    {

    }

    public override string ToString()
    {
        string str = base.ToString();
        return str;
    }

    public bool Equals(Rectangle? other)
    {
        if(other == null)
            return false;

        if(Object.ReferenceEquals(this, other))
            return true;

        if (this.GetType() != other.GetType())
            return false;
    }
     

    public override int GetHashCode()
    {
        return HashCode.Combine(TopLeft.X ,TopLeft.Y ,Width ,Height);
    }
}
