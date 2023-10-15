namespace GameCrud.Contracts.GameCrud;

public record GameResp(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Category,
    List<string> Platform);