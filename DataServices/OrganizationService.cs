﻿using AutoMapper;
using CMS.Data;
using CMS.Interfaces;
using CMS.Model;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;
using static Models.GqlCommon.Inputs.OrganizationInputs;

namespace DataServices
{
    public class OrganizationService : DbFactoryFetcher, IOrganizationService
    {
        public OrganizationService(IDbContextFactory<ApplicationDbContext> dbContextFactory,
            IMapper mapper) : base(dbContextFactory, mapper)
        {
        }

        public async Task<OrganizationDto> CreateOrganization(CreateOrganizationInput input)
        {
            string trimmedOrgName = input.organizationName.Trim();
            if (input.userId == Guid.Empty)
            {
                throw new ArgumentException("Guid is empty");
            }
            if (string.IsNullOrEmpty(trimmedOrgName) || string.IsNullOrWhiteSpace(trimmedOrgName))
            {
                throw new ArgumentNullException(nameof(trimmedOrgName));
            }

            bool doesExist = this._context.Organizations.Any(o => o.Name == trimmedOrgName);
            if (doesExist)
            {
                throw new ArgumentException("Organization name already exists !");
            }

            var newOrganization = new Organization()
            {
                Id = Guid.NewGuid(),
                Name = trimmedOrgName,
            };

            var userStub = new User() { Id = input.userId };
            this._context.Entry(userStub).State = EntityState.Unchanged;

            await this._context.OrganizationUser.AddAsync(new OrganizationUser()
            {
                Organization = newOrganization,
                User = userStub
            });

            await this._context.SaveChangesAsync();

            var orgDto = _mapper.Map<OrganizationDto>(newOrganization);
            return orgDto;
        }

        public async Task DeleteOrganization(DeleteOrganizationInput input)
        {
            var organizationForUser = await this._context.OrganizationUser
                .Include(ou => ou.User)
                .Include(ou => ou.Organization)
                .FirstOrDefaultAsync(ou => (ou.OrganizationId == input.organizationId &&
                                       ou.UserId == input.userId));

            if (organizationForUser == null)
            {
                throw new ArgumentException("User is not part of this organization");
            }
            else if (organizationForUser.User.UserRole != Models.Enums.UserRole.Admin)
            {
                throw new ArgumentException("User is a part of the organization, but not an Admin !");
            }
            else
            {
                this._context.Organizations.Remove(organizationForUser.Organization);
                await this._context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<OrganizationDto>> GetOrganizationsByUser(Guid userId)
        {
            var organizationsForUser = await this._context.Organizations
                .Where(o => o.OrganizationUser
                .Any(u => u.UserId == userId)
                )
                .Include(o => o.OrganizationUser)
                .ThenInclude(ou => ou.User)
                .Include(o => o.Spaces)
                .ToListAsync();

            return _mapper.Map<IEnumerable<Organization>, IEnumerable<OrganizationDto>>(organizationsForUser);
        }
    }
}
