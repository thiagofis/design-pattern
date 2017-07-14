namespace Abstract_Factory.Models
{
    public class Player
    {
        public string Name { get; set; }

        public Country Nation { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Nation: {Nation}";

        }
    }
}
