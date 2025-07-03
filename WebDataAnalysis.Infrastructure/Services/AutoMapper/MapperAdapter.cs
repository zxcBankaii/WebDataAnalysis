using WebDataAnalysis.Application.Interfaces;

namespace WebDataAnalysis.Infrastructure.Services.AutoMapper;

public class MapperAdapter : IMapper
{
    private readonly global::AutoMapper.IMapper _mapperAdapter;

    public MapperAdapter(global::AutoMapper.IMapper mapperAdapter)
    {
        _mapperAdapter = mapperAdapter;
    }

    public TDestination Map<TSource, TDestination>(TSource source)
    {
        return _mapperAdapter.Map<TDestination>(source);
    }
}