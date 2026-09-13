namespace TodoApi.Dtos;

public record LoginDto(
    string Username,
    string Password
);

public record LoginResponseDto(
    String Token,
    DateTime Expiration );