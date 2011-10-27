using ILoveAOP.Services;
using StructureMap;
using StructureMap.Interceptors;

namespace ILoveAOP
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IRandomNumberService>().Use<RandomNumberService>().EnrichWith(InterceptorFactory<IRandomNumberService>.Create);

                        });
            return ObjectFactory.Container;
        }
    }
}