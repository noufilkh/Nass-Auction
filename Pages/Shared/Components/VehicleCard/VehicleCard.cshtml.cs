
using Microsoft.AspNetCore.Mvc;
using VechileAuctionApp.Models;

public class VehicleCardViewComponent : ViewComponent
{
    private readonly IConfiguration _configuration;

    public List<Vehicle> vehicles = new();

    public VehicleCardViewComponent(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        vehicles.Clear();
        vehicles.AddRange(
            new Vehicle()
            {
                Id = 1,
                Code = "code-001",
                Brand = "BMW",
                Model = "M4 Comp",
                Year = "2021",
                Number = "Num-001",
                Milleage = "12,450",
                Transmission = "Auto",
                Fuel = "Petrol",
                CurrentBid = "$72,500",
                Ends = "02:15:40",
                ImageURL = "https://images.unsplash.com/photo-1555215695-3004980ad54e?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            },
            new Vehicle()
            {
                Id = 2,
                Code = "code-002",
                Brand = "Porsche",
                Model = "911 Carrera S",
                Year = "2019",
                Number = "Num-002",
                Milleage = "28,000",
                Transmission = "PDK",
                Fuel = "Petrol",
                CurrentBid = "$105,000",
                Ends = "05:42:10",
                Badge = "Hot",
                BadgeIcon = "fa-fire",
                ImageURL = "https://placehold.co/600x400/eeeeee/999999?text=Porsche+911"
            },
            new Vehicle()
            {
                Id = 3,
                Code = "code-003",
                Brand = "Ferrari",
                Model = "308 GTSi",
                Year = "1982",
                Number = "Num-003",
                Milleage = "45,000",
                Transmission = "Manual",
                Fuel = "Petrol",
                CurrentBid = "$85,500",
                Ends = "18:20:00",
                Badge = "Classic",
                BadgeIcon = "fa-star",
                ImageURL = "https://images.unsplash.com/photo-1583121274602-3e2820c69888?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            },
            new Vehicle()
            {
                Id = 4,
                Code = "code-004",
                Brand = "Tesla",
                Model = "Model S Plaid",
                Year = "2022",
                Number = "Num-004",
                Milleage = "5,100",
                Transmission = "Auto",
                Fuel = "Electric",
                CurrentBid = "$88,900",
                Ends = "12:30:00",
                Badge = "Eco",
                BadgeIcon = "fa-leaf",
                ImageURL = "https://images.unsplash.com/photo-1560958089-b8a1929cea89?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            },
            new Vehicle()
            {
                Id = 5,
                Code = "code-005",
                Brand = "Rivian",
                Model = "R1T Launch Ed.",
                Year = "2022",
                Number = "Num-005",
                Milleage = "8,500",
                Transmission = "Auto",
                Fuel = "Electric",
                CurrentBid = "$76,000",
                Ends = "05:20:00",
                Badge = "Eco",
                BadgeIcon = "fa-leaf",
                ImageURL = "https://images.unsplash.com/photo-1614200179396-2bdb77ebf81b?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            },
            new Vehicle()
            {
                Id = 6,
                Code = "code-006",
                Brand = "Challenger",
                Model = "SRT Hellcat",
                Year = "2021",
                Number = "Num-006",
                Milleage = "15,400",
                Transmission = "Auto",
                Fuel = "Petrol",
                CurrentBid = "$62,500",
                Ends = "13:10:00",
                Badge = "",
                BadgeIcon = "",
                ImageURL = "https://images.unsplash.com/photo-1520031441872-265e4ff70366?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            },
            new Vehicle()
            {
                Id = 7,
                Code = "code-7",
                Brand = "BMW",
                Model = "M5 Competition",
                Year = "2020",
                Number = "Num-007",
                Milleage = "26,000",
                Transmission = "Auto",
                Fuel = "Petrol",
                CurrentBid = "$84,000",
                Ends = "02:45:00",
                Badge = "",
                BadgeIcon = "",
                ImageURL = "https://images.unsplash.com/photo-1580273916550-e323be2ae537?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            },
            new Vehicle()
            {
                Id = 8,
                Code = "code-008",
                Brand = "Bentley",
                Model = "Continental GT",
                Year = "2021",
                Number = "Num-008",
                Milleage = "12,000",
                Transmission = "Auto",
                Fuel = "Petrol",
                CurrentBid = "$88,900",
                Ends = "12:30:00",
                Badge = "Premium",
                BadgeIcon = "fa-crown",
                ImageURL = "https://images.unsplash.com/photo-1618843479313-40f8afb4b4d8?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            },
            new Vehicle()
            {
                Id = 9,
                Code = "code-009",
                Brand = "Lamborghini",
                Model = "Huracan",
                Year = "2018",
                Number = "Num-009",
                Milleage = "11,200",
                Transmission = "Auto",
                Fuel = "Petrol",
                CurrentBid = "$265,000",
                Ends = "06:30:00",
                Badge = "",
                BadgeIcon = "",
                ImageURL = "https://images.unsplash.com/photo-1532581140115-3e355d1ed1de?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
            }
        );

        return View(vehicles);
    }
}