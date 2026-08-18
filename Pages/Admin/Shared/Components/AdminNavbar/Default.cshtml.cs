
using Microsoft.AspNetCore.Mvc;
using VechileAuctionApp.Models;

public class AdminNavbarViewComponent : ViewComponent
{
    private readonly IConfiguration _configuration;

    public List<Vehicle> vehicles = new();

    public AdminNavbarViewComponent(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View("~/Pages/Admin/Shared/Components/AdminNavbar/Default.cshtml");
    }
}