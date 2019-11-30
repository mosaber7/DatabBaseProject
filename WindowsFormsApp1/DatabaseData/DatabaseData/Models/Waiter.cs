namespace DatabaseData.Models
{
    public class Waiter
    {
        public string FirstName { get; }
        
        public string LastName { get; }

        public Waiter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
    }
}
