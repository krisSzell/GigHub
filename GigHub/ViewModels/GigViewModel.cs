﻿using GigHub.Models;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.ViewModels
{
    public class GigViewModel
    {
        public ILookup<int, Attendance> Attendances;

        public IEnumerable<Gig> UpcomingGigs { get; set; }

        public bool ShowActions { get; set; }

        public string Heading { get; set; }

        public string SearchTerm { get; set; }
    }

}