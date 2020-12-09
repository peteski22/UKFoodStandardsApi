namespace InfinityWorks.TechTest.Core.Domain
{
    public class LocalAuthority
    {
        public int Id { get; }

        public string Name { get; }

        public LocalAuthority(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
