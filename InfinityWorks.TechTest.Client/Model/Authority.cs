namespace InfinityWorks.TechTest.Client.Model
{
    public class Authority
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Authority[{nameof(Id)}={Id}, {nameof(Name)}='{Name}']";
        }
    }
}