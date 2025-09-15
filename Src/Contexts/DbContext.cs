using Devroutine.Contexts;
using Devroutine.Models;
using Microsoft.EntityFrameworkCore;

namespace Devroutine.Contexts;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}