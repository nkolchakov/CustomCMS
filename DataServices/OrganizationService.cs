using AutoMapper;
using CMS.Data;
using CMS.Interfaces;
using CMS.Model;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public class OrganizationService : DbFactoryFetcher, IOrganizationService
    {
        public OrganizationService(IDbContextFactory<ApplicationDbContext> dbContextFactory,
            IMapper mapper) : base(dbContextFactory, mapper)
        {
        }

        public async Task<IEnumerable<OrganizationDto>> GetOrganizationsByUser(Guid userId)
        {
            var organizationsForUser = await this._context.Organizations
                .Where(o => o.OrganizationUser
                .Any(u => u.UserId == userId)
                ).Include(o => o.Spaces)
                .ToListAsync();

            return _mapper.Map<IEnumerable<Organization>, IEnumerable<OrganizationDto>>(organizationsForUser);
        }
    }
}
