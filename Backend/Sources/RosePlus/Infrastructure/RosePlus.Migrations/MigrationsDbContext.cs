using Microsoft.EntityFrameworkCore;
using RosePlus.DataAccess.Context;

namespace RosePlus.Migrations;

public class MigrationsDbContext : RosePlusContext
{
    public MigrationsDbContext(DbContextOptions<MigrationsDbContext> options) : base(options)
    {
    }
}