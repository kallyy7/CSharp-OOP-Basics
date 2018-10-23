namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string firstDate = System.Console.ReadLine();
            string secondDate = System.Console.ReadLine();

            System.Console.WriteLine(DateModifier.CalculateDifference(firstDate, secondDate));
        }
    }
}
