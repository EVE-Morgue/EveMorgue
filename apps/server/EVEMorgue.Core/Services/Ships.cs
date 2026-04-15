using EVEMorgue.Core.DTOs;
using EVEMorgue.Core.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEMorgue.Core.Services
{
    public class ShipsService : IShipService
    {
        // Sample data for demonstration purposes
        Dictionary<int, string> _ships = new()
        {
            { 1, "Rifter" },
            { 2, "Merlin" },
            { 3, "Incursus" },
            { 4, "Atron" },
            { 5, "Kestrel" },
            { 638, "Raven" }
        };

        Dictionary<int, ShipDetailsDto> _shipDetails = new()
        {
            {
                638,
                new ShipDetailsDto(
                    638,
                    "Raven",
                    "The Raven is the powerhouse of the Caldari Navy. With its myriad launcher slots and powerful shields, few ships can rival it in strength or majesty.",
                    27,
                    null,
                    null)
            }
        };


        public Dictionary<int, string> Search(string searchTerm)
        {

            return _ships.Where(s => s.Value.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                          .ToDictionary(s => s.Key, s => s.Value);
        }

        public ShipDetailsDto? GetDetails(int shipId)
        {
            _shipDetails.TryGetValue(shipId, out var details);
            return details;
        }
    }
}
