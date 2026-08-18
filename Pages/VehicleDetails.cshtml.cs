using System.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VechileAuctionApp.Pages;

public class VehicleDetailsModel : PageModel
{
    public int VehicleId { get; set; }
    private readonly ILogger<ErrorModel> _logger;

    private readonly IConfiguration _configuration;

    public String Mydate { get; set; }


    public VehicleDetailsModel(ILogger<ErrorModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public void OnGet(int id)
    {
        VehicleId = id;
        DataConnection _conn = new DataConnection(_configuration);
        DataTable mytable = _conn.GetDataTable("[Get My date]", new string[] { }, new object[] { });
        Mydate = (mytable != null && mytable.Rows.Count > 0) ? Convert.ToString(mytable.Rows[0]["Date"]) : "No Date Found";

    }
}

