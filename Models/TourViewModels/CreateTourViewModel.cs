using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;

namespace buyticketforbus.Models.TourViewModels
{
    public class CreateTourViewModel
    {
        public required List<Station> stations { get; set; } = null!;
        public required int expectedArrivedTime { get; set; }

        public required string firstStation { get; set; } = null!;

        public required string finishStation { get; set; } = null!;

        public required string departureDate { get; set; }

        public required string busPlaka { get; set; } = null!;

        public required int firstDriverId { get; set; }

        public required int secondDriverId { get; set; }
        
        public required int hostId { get; set; }
    }
}