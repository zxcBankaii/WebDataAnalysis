using System.Text.Json.Serialization;

namespace WebDataAnalysis.Application.UseCase.FindDevices.AllCountFindDevicesByCategory;

public class AllCountFindDevicesByCategoryResponse
{
    [JsonPropertyName("nameCategory")]
    public string NameCategory { get; set; }
    
    [JsonPropertyName("deviceName")]
    public List<string> DeviceName { get; set; }
    
    [JsonPropertyName("countFindDevice")]
    public int CountFindDevice { get; set; }
    
}