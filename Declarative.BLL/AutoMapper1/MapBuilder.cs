using AutoMapper;

namespace Declarative.BLL.AutoMapper1
{
    public class MapBuilder
    {
        static IMapper mapper;
        public static IMapper Build()
        {
            if(mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AutoMapperProfile());
                });
                mapper = mappingConfig.CreateMapper();
            }
            return mapper;
        }
    }
}
