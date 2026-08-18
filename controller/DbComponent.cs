using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

public class DataConnection
{
    private readonly string _connectionString;
    private SqlConnection _sqlConnection;

    public DataConnection(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string not found.");
    }

    private SqlConnection GetConnection()
    {
        if (_sqlConnection != null && _sqlConnection.State == System.Data.ConnectionState.Open)
        {
            return _sqlConnection;
        }

        _sqlConnection = new SqlConnection(_connectionString);
        _sqlConnection.Open();

        return _sqlConnection;
    }


    public DataTable GetDataTable(string procedure, string[] keys, object[] values)
    {
        ArgumentNullException.ThrowIfNull(keys);
        ArgumentNullException.ThrowIfNull(values);

        if (keys.Length != values.Length)
            throw new ArgumentException("Keys and values count must match.");

        DataTable dt = new();

        using SqlConnection con = GetConnection();
        using (SqlCommand cmd = new SqlCommand(procedure, con))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < keys.Length; i++)
            {
                cmd.Parameters.AddWithValue(keys[i], values[i] ?? DBNull.Value);
            }

            using SqlDataAdapter da = new(cmd);
            da.Fill(dt);
        }

        return dt;
    }

    public int ExecuteNonQuery(string procedure, string[] keys, object[] values)
    {
        ArgumentNullException.ThrowIfNull(keys);
        ArgumentNullException.ThrowIfNull(values);

        if (keys.Length != values.Length)
            throw new ArgumentException("Keys and values count must match.");

        using SqlConnection con = GetConnection();
        using SqlCommand cmd = new SqlCommand(procedure, con);

        cmd.CommandType = CommandType.StoredProcedure;

        for (int i = 0; i < keys.Length; i++)
        {
            cmd.Parameters.AddWithValue(keys[i], values[i] ?? DBNull.Value);
        }

        con.Open();
        return cmd.ExecuteNonQuery();
    }
}



