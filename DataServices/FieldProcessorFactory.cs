using DataServices.Interfaces;
using DataServices.Processors;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public class FieldProcessorFactory
    {
        private readonly IServiceProvider serviceProvider;

        public FieldProcessorFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IFieldProcesssorService GetFieldProcessor(CMS_TYPE type)
        {
            IFieldProcesssorService service = null;
            switch (type)
            {
                case CMS_TYPE.Asset:
                    service = (IFieldProcesssorService)serviceProvider.GetService(typeof(FileFieldProcessor));
                    break;
                case CMS_TYPE.Array:
                    service = (IFieldProcesssorService)serviceProvider.GetService(typeof(ListFieldProcessor));
                    break;
                case CMS_TYPE.Text:
                case CMS_TYPE.Number:
                    service = (IFieldProcesssorService)serviceProvider.GetService(typeof(PlainFieldProcessor));
                    break;
                default:
                    break;
            }
            if (service == null)
            {
                throw new ArgumentException($"Provider not set for {type}");
            }
            return service;
        }
    }
}
