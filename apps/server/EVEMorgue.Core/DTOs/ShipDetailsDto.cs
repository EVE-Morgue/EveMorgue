namespace EVEMorgue.Core.DTOs;

public record ShipDetailsDto(
    int Id,
    string Name,
    string Description,
    int GroupId,
    int? CategoryId,
    object? Attributes
);
