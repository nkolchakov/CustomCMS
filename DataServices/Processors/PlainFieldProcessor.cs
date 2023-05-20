using CMS.Model;
using DataServices.Interfaces;

namespace DataServices.Processors
{
    public class PlainFieldProcessor : IFieldProcesssorService
    {
        public Task<string> ProcessValue(Guid contentTypeId, BasicField field)
        {
            return Task.FromResult(String.IsNullOrEmpty(field.Value) ? null : field.Value.ToString());
        }
    }
}
