using MediatR;
using WebDataAnalysis.Domain.Utils;

namespace WebDataAnalysis.Application.UseCase.FindDevices.FindDeviceByCategory;

public class FindDeviceByCategoryCommand : IRequest<Result<List<FindDeviceByCategoryResponse>>>
{
    
}