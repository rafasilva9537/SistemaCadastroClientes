using System.ComponentModel.DataAnnotations;

namespace MvcApp.Configs;

public class ViaCepConfigs
{
    public const string NomeSection = "ViaCepConfigs";
    
    [Required]
    [RegularExpression(@"^https?:\/\/(?:www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b(?:[-a-zA-Z0-9()@:%_\+.~#?&\/=]*)$")]
    public required string UrlBase { get; set; }
}