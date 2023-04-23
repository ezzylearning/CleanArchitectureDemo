
namespace CleanArchitectureDemo.Application.DTOs.Email
{
    public class EmailRequestDto
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
    }
}
