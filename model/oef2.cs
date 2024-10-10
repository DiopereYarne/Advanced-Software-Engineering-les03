namespace oef2.Models
{
    public class LibraryItem{
        public string Title { get; set; }
        public string ID { get; set; }
        public string yearPublished { get; set; }

        public LibraryItem(string title, string id, string yearpublished)
        {
            Title = title;
            ID = id;
            yearPublished = yearpublished;
        }

        public virtual void PrintDetails(){
            Console.WriteLine("Title: {0}, ID: {1}, Year Published: {2}", Title, ID, yearPublished);
        }
    }

   public class Book : LibraryItem
{
    public string Author { get; set; }
    
    public Book(string title, string id, string yearPublished, string author) 
        : base(title, id, yearPublished)
    {
        Author = author;
    }

    public override void PrintDetails()
    {
        Console.WriteLine("Title: {0}, ID: {1}, Year Published: {2}, Author: {3}", Title, ID, yearPublished, Author);
    }
}


    public class magazine : LibraryItem
    {
        public string IssueNumber { get; set; }

        public magazine(string title, string id, string yearPublished, string issueNumber) : base(title, id, yearPublished)
        {
            IssueNumber = issueNumber;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("Title: {0}, ID: {1}, Year Published: {2}, Issue Number: {3}", Title, ID, yearPublished, IssueNumber);
        }
    }

    public class DVD : LibraryItem
    {
        public int duration { get; set; }

        public DVD(string title, string id, string yearPublished, int Duration) : base(title, id, yearPublished)
        {
            duration = Duration;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("Title: {0}, ID: {1}, Year Published: {2}, Duration: {3}", Title, ID, yearPublished, duration);
        }
    }
}