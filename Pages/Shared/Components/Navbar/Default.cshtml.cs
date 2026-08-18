
using Microsoft.AspNetCore.Mvc;
using VechileAuctionApp.Models;

public class NavbarViewComponent : ViewComponent
{
    private readonly IConfiguration _configuration;

    public List<Vehicle> vehicles = new();

    public NavbarViewComponent(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}