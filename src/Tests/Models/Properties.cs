namespace Tests.Models
{
    public class Properties
    {
        public string connectionProviderId { get; set; }
        public string displayName { get; set; }
        public string iconUri { get; set; }
        public Status status { get; set; }
        public ConnectionParameters connectionParameters { get; set; }
    }
}