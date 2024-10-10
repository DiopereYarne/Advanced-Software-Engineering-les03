namespace oef4.Models
{
    // Define WineType enumeration
    public enum WineType
    {
        RED,
        WHITE,
        ROSE,
        SPARKLING
    }

    // Base class
    public abstract class Collectible : IComparable<Collectible>
    {
        public string Name { get; set; }
        public int YearOfOrigin { get; set; }
        public double Price { get; set; }

        // Calculated property
        public double StartBidPrice => Price * 0.8;

        // Abstract property for CollectType
        public abstract string CollectType { get; }

        // Implement IComparable
        public int CompareTo(Collectible other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    // Wine class
    public class Wine : Collectible
    {
        public double PricePerGlass { get; set; }
        public string Country { get; set; }
        public WineType Type { get; set; }

        public override string CollectType => $"{Type.ToString().ToLower()} wine";

        public override string ToString()
        {
            return $"{Name} ({Country})";
        }
    }

    // PostStamp class
    public class PostStamp : Collectible
    {
        public string Image { get; set; }

        public override string CollectType => "post stamp";

        public override string ToString()
        {
            return Name;
        }
    }

    // ComicBook class
    public class ComicBook : Collectible
    {
        public string Publisher { get; set; }
        public string Author { get; set; }

        public override string CollectType => "comic book";

        public override string ToString()
        {
            return $"{Name} ({Author})";
        }
    }
}