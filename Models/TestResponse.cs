using System.Reflection;

namespace EndpointHelper.Models
{
    public class TestResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CreatedDateN { get; set; }
        public List<string> ListStr { get; set; }
        public TestResponse TestResponses { get; set; }
        public List<TestResponse> TestResponsesList { get; set; }
        public Exception Exc { get; set; }
        public CustomException CustomExc { get; set; }
        // public Exception Exc { get; set; }
    }
}