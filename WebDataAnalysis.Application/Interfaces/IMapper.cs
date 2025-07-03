namespace WebDataAnalysis.Application.Interfaces;

public interface IMapper
{
    TDestination Map<TSourse, TDestination>(TSourse sourse);
}