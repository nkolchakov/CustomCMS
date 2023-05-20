using CMS.Model;
using DataServices.Interfaces;
using Models;
using Models.GqlCommon.Inputs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataServices.Processors
{
    /**
     * Deserialize
     * Assign new ID, for the newly created
     * Attach the ListItems to the collection
     */
    public class ListFieldProcessor : IFieldProcesssorService
    {
        public Task<string> ProcessValue(Guid contentTypeId, BasicField field)
        {
            
            field.ListItems = field.ListItems.Select(item =>
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                item.BasicFieldId = field.Id;
                return item;

            }).ToList();
            
            return Task.FromResult<string>(null);
        }
    }
}
