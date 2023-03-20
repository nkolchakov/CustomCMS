using AutoMapper;
using CMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public abstract class DbFactoryFetcher: IDisposable
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public DbFactoryFetcher(IDbContextFactory<ApplicationDbContext> dbContextFactory, IMapper mapper)
        {
            this._context = dbContextFactory.CreateDbContext();
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
