using EVEMorgue.Core.DTOs;

namespace EVEMorgue.Core.ServicesContracts
{
    public interface IShipService : IShipsService, IShipDetails;

    public interface IShipDetails
    {
        /// <summary>
        /// Retrieves detailed information about a ship by its unique identifier.
        /// </summary>
        /// <param name="shipId">The unique identifier of the ship for which to retrieve details. Must be a valid, existing ship ID.</param>
        /// <returns>A <see cref="ShipDetailsDto"/> containing the ship's details if found; otherwise, <see langword="null"/>.</returns>
        ShipDetailsDto? GetDetails(int shipId);
    }
    public interface IShipsService
    {
        /// <summary>
        /// Searches for ships whose names contain the specified search term, using a case-insensitive comparison.
        /// </summary>
        /// <param name="searchTerm">The term to search for within ship names. The search is case-insensitive. Cannot be null.</param>
        /// <returns>A dictionary containing the IDs and names of ships that match the search term. The dictionary is empty if no
        /// matches are found.</returns>
        Dictionary<int, string> Search(string searchTerm);
    }
}
