namespace EndpointHelper.Models.TestModels
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}