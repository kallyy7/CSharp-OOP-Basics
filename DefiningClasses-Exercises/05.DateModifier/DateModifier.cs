namespace DefiningClasses
{
    public class DateModifier
    {
        public static int CalculateDifference(string firstDate, string secondDate)
        {
            var difference = System.DateTime.Parse(firstDate) - System.DateTime.Parse(secondDate);

            return System.Math.Abs(difference.Days);
        }
    }
}
