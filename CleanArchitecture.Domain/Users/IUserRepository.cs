namespace CleanArchitecture.Domain.Users;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(User user);
    Task<User> Update(User user);
}
