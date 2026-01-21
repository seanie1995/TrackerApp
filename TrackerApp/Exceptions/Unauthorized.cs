namespace TrackerApp.Exceptions
{
    public class UnauthorizedActionException : Exception
    {
       public UnauthorizedActionException(string message) : base(message) { }
    }
}
