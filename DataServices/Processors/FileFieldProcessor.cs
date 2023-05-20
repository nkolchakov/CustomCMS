using CMS.Model;
using DataServices.Interfaces;
using Models.GqlCommon.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Processors
{
    /**
        1. validate
        2. upload to Azure
        3. set the URL as new value
        
     */
    public class FileFieldProcessor : IFieldProcesssorService
    {
        public Task<string> ProcessValue(Guid contentTypeId,BasicField field)
        {
            return Task.FromResult("Test");
            throw new NotImplementedException();
        }
    }
}
