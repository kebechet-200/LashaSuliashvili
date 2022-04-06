using MoviesManagement.Web.Models.Enum;

namespace MoviesManagement.Web.Models
{
    public class TicketViewModel
    {
        public string UserId { get; set; }
        public int MovieId { get; set; }

        public TicketStatusEnum State { get; set; }
    }
}
