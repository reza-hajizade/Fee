using Fee.Infrastructure;

namespace Fee.Application.Services
{
    public sealed class FeeServices(FeeDbContext context)
    {
        public FeeDbContext Context { get; } = context;
    }

}
