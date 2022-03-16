using AutoMapper;
using Ifeanyi.Services.productAPI.DataTransferObjects.Readable;
using Ifeanyi.Services.productAPI.Models;

namespace Ifeanyi.Services.productAPI.Helpers
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();
            });
            return mappingConfig;
        }
    }
}
