
namespace VechileAuctionApp.Models;

public class Vehicle
{
    public int Id { get; set; }

    public string ImageURL { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string Year { get; set; } = string.Empty;

    public string Number { get; set; } = string.Empty;

    public string Milleage { get; set; } = string.Empty;

    public string Transmission { get; set; } = string.Empty;

    public string Fuel { get; set; } = string.Empty;

    public string CurrentBid { get; set; } = string.Empty;

    public string Ends { get; set; } = string.Empty;

    public string Badge { get; set; } = string.Empty;

    public string BadgeIcon { get; set; } = string.Empty;
}

