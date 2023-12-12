using Newtonsoft.Json;

namespace HyperCompanyCase.Core.Utilities.Result
{
    public class DataResult
    {
        [JsonProperty("isError")] public bool IsError => ErrorMessageList?.Count > 0;
        [JsonProperty("errorMessageList")] public List<string> ErrorMessageList { get; set; } = new();
        [JsonProperty("total")] public int Total { get; set; }
        [JsonProperty("data")] public object Data { get; set; }
    }
}
