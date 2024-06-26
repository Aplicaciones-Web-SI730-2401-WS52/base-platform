using BasePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using BasePlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using BasePlatform.API.Urgency.Domain.Models.Entities;
using BasePlatform.API.Urgency.Domain.Repositories;

namespace BasePlatform.API.Urgency.Infraestructure.Respositories;

public class GuardianRepository : BaseRepository<Guardian>,IGuardianRepository
{
    public GuardianRepository(AppDbContext context) : base(context)
    {
    }
}