namespace LineComparison
{
    public class Lenthofline
    {
       public static void Main(string[] args)
        {
            //
            Random random= new Random();
            //
            int x1 = random.Next(0,10);
            int y1 = random.Next(0,10);
            int x2 = random.Next(0,10);
            int y2 = random.Next(0,10);
            //
            double LENGTH = Math.Sqrt(((x2-x1)^2)+((y2-y1)^2));
            Console.WriteLine("length of line :"+LENGTH);
        }
    }
}