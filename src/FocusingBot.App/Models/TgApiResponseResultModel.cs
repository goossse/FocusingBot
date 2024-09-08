using Newtonsoft.Json;

namespace FocusingBot.App.Models;

public class TgApiResponseResultModel
{
    [JsonProperty("id")]
    public long Id { get; set; }
    
    [JsonProperty("is_bot")]
    public bool IsBot { get; set; }
    
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    
    [JsonProperty("username")]
    public string Username { get; set; }
    
    [JsonProperty("can_join_groups")]
    public bool IsAbleJoinGroups { get; set; }
}