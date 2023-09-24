using System;

namespace Play.Catalog.Sercie.Dtos
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset createdDate);
    public record CreateItemDto(string Name, string Description, decimal Price);
    public record UpdateItemDto(string Name, string Description, decimal Price);
}