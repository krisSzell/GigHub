using GigHub.Models;
using System;

namespace GigHub.ViewModels
{
    public class GigDetailsViewModel
    {
        public ApplicationUser Artist { get; set; }
        public Genre Genre { get; set; }
        public string Venue { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsAttending { get; set; }
        public bool IsFollowing { get; set; }

    }
}
