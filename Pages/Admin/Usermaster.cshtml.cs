using System.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VechileAuctionApp.Pages.Admin;

public class UsermasterModel : PageModel
{
    public List<User> myUsers { get; set; } = new();

    private DataConnection dbconnection;


    public UsermasterModel(IConfiguration configuration)
    {        
        dbconnection = new DataConnection(configuration);
    }


    public void OnGet()
    {
    }

    public void OnPostSearch()
    {
        DataTable table = dbconnection.GetDataTable("[Get My date]", new string[]{}, new object[]{});
        myUsers = ConvertDataTableToUsers(table);        
    }

    public static List<User> ConvertDataTableToUsers(DataTable table)
    {
        var users = new List<User>();

        if (table == null)
            return users;

        foreach (DataRow row in table.Rows)
        {
            var user = new User
            {
                Userid = row["Userid"] != DBNull.Value ? Convert.ToInt32(row["Userid"]) : 0,
                Username = row["Username"] != DBNull.Value ? Convert.ToString(row["Username"]) ?? string.Empty : string.Empty,
                Password = row["Password"] != DBNull.Value ? Convert.ToString(row["Password"]) ?? string.Empty : string.Empty,
                FullName = row["FullName"] != DBNull.Value ? Convert.ToString(row["FullName"]) ?? string.Empty : string.Empty,
                Nationality = row["Nationality"] != DBNull.Value ? Convert.ToString(row["Nationality"]) ?? string.Empty : string.Empty,
                Email = row["Email"] != DBNull.Value ? Convert.ToString(row["Email"]) ?? string.Empty : string.Empty,
                Phone = row["Phone"] != DBNull.Value ? Convert.ToString(row["Phone"]) ?? string.Empty : string.Empty,
                Role = row["Role"] != DBNull.Value ? Convert.ToString(row["Role"]) ?? string.Empty : string.Empty,
                Status = row["Status"] != DBNull.Value ? Convert.ToString(row["Status"]) ?? string.Empty : string.Empty,
                Expiry = row["Expiry"] != DBNull.Value ? Convert.ToString(row["Expiry"]) ?? string.Empty : string.Empty
            };

            users.Add(user);
        }

        return users;
    }
}

public class User
{
    public int Userid { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }
    public string FullName { get; set; }
    public string Nationality { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    public string Status { get; set; }
    public string Expiry { get; set; }
}
