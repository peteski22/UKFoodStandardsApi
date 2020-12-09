namespace InfinityWorks.TechTest.Core.Domain
{
    public class Rating
    {
        public string Name { get; }

        public double Percentage { get; }

        public Rating(string name, double percentage)
        {
            Name = name;
            Percentage = percentage;
        }
    }
}
