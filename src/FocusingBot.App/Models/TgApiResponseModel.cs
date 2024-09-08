using Newtonsoft.Json;

namespace FocusingBot.App.Models;

public class TgApiResponseModel
{
    [JsonProperty("ok")]
    public bool IsStatusOk { get; set; }
    
    [JsonProperty("result")]
    public TgApiResponseResultModel Result { get; set; }
}

