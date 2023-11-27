using Microsoft.AspNetCore.Mvc;
namespace DreamtGame.Models
{
    public class OptionsModel
    {
        public string? Userename { get; set; }
        public bool ColorBlind { get; set; }
        public int? Score { get; set; }

    }
}
