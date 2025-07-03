using MediatR;
using WebDataAnalysis.Application.Interfaces;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Utils;

namespace WebDataAnalysis.Application.UseCase.FindDevices.AllCountFindDevicesByCategory;

public class AllCountFindDevicesByCategoryHandler : IRequestHandler<AllCountFindDevicesByCategoryCommand,
    Result<List<AllCountFindDevicesByCategoryResponse>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AllCountFindDevicesByCategoryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<List<AllCountFindDevicesByCategoryResponse>>> Handle(AllCountFindDevicesByCategoryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var allCategory = await _unitOfWork.CategoryRepository.GetAllAsync();
            
            List<AllCountFindDevicesByCategoryResponse> allCountFindDevicesByCategoryResponses = new List<AllCountFindDevicesByCategoryResponse>();

            foreach (var item in allCategory)
            {
                var deviceByCategory = await _unitOfWork.DeviceRepository.GetListByIdCategory(item.Id);
                List<DeviceMapping> findDevice = new List<DeviceMapping>();
                foreach (var subItem in deviceByCategory)
                {
                    findDevice.AddRange(await _unitOfWork.DeviceMappingRepository.GetListByIdDevices(subItem.Id));
                }
                AllCountFindDevicesByCategoryResponse allCountFindDevicesByCategoryResponse = new AllCountFindDevicesByCategoryResponse()
                {
                    NameCategory = item.Title,
                    DeviceName = deviceByCategory.Select(x=>x.Title).ToList(),
                    CountFindDevice = findDevice.Count,
                };
                allCountFindDevicesByCategoryResponses.Add(allCountFindDevicesByCategoryResponse);
            }
            return Result<List<AllCountFindDevicesByCategoryResponse>>.Success(allCountFindDevicesByCategoryResponses);
        }
        catch (Exception e)
        {
            return Result<List<AllCountFindDevicesByCategoryResponse>>.ServerError("Some error! " + e);
        }
    }
}