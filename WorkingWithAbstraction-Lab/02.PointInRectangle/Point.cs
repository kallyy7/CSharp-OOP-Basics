public class Point
{
    private int x;
    private int y;

    public int X
    {
        get => this.x; 
        set => x = value; 
    }

    public int Y
    {
        get => this.y;
        set => y = value;
    }


    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}