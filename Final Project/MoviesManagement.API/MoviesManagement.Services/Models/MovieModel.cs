using System;

namespace MoviesManagement.Services.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
    }
}
