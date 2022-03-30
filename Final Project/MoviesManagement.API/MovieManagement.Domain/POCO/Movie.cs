﻿using System;
using System.Collections.Generic;

namespace MoviesManagement.Domain.POCO
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsExpired { get; set; }

        //navigation property
        public List<Ticket> Tickets { get; set; }

    }
}
