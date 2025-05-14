// See https://aka.ms/new-console-template for more information
class Rectangle {
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(int length, int width) {
        Length = length;
        Width = width;
    }

    public int Area() {
        return Length * Width;
    }
    public int Perimeter() {
        return 2 * (Length + Width);
    }
    public void Display() {
        Console.WriteLine($"Length: {Length}, Width: {Width}");
        Console.WriteLine($"Area: {Area()}");
        Console.WriteLine($"Perimeter: {Perimeter()}");
    }
    public void Main(string[] args) {
        Rectangle rect = new Rectangle(5, 10);
        rect.Display();
    }
}