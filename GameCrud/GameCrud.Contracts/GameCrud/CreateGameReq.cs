namespace GameCrud.Contracts.GameCrud;

public record CreateGameReq(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Category,
    List<string> Platform);