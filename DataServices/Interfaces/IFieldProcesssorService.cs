using CMS.Model;
using Models.GqlCommon.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Interfaces
{
    public interface IFieldProcesssorService
    {
        Task<string> ProcessValue(Guid contentTypeId, BasicField field);
    }
}
