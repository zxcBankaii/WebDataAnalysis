using System.Text.Json.Serialization;

namespace WebDataAnalysis.Application.UseCase.FindDevices.FindDeviceByCategory;

public class FindDeviceByCategoryResponse
{
    [JsonPropertyName("nameFindDevice")]
    public Guid Id { get; set; }
    
    [JsonPropertyName("countFindDevice")]
    public int CountFindDevice { get; set; }

}