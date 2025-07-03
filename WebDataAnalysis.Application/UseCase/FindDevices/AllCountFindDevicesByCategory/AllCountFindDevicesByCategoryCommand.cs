using MediatR;
using WebDataAnalysis.Domain.Utils;

namespace WebDataAnalysis.Application.UseCase.FindDevices.AllCountFindDevicesByCategory;

public class AllCountFindDevicesByCategoryCommand : IRequest<Result<List<AllCountFindDevicesByCategoryResponse>>>
{
    
}