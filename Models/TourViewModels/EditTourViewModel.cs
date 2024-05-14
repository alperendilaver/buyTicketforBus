using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;

namespace buyticketforbus.Models.TourViewModels
{
    public class EditTourViewModel
    {
        public int tourId { get; set; }

         public required List<Station> stations { get; set; } = null!;
        public required int expectedArrivedTime { get; set; }

        public required Station firstStation { get; set; } = null!;

        public required Station finishStation { get; set; } = null!;

        public required DateTime departureDate { get; set; }

        public required Bus bus { get; set; } = null!;

        
    }
}