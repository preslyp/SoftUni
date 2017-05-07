namespace ConsoleApplication1.Interfaces
{
  
    public interface IMovable 
    {
        double X { get; set; }

        double Y { get; set; }

        void Move(double deltaX, double deltaY);
    }
}
