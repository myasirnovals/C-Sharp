namespace Latihan4;

public class GameLabDB
{
    public bool opeConnection()
    {
        Console.WriteLine("open connection");
        bool connectStatus = false;
        // disini bisa berupa kode yang rumit
        // dan panjang lebar
        // berisi kode program koneksi ke database
        return connectStatus;
    }

    public bool closeConnection()
    {
        Console.WriteLine("close connection");
        bool closeStatus = false;
        // disini kode untuk tutup koneksi
        return closeStatus;
    }

    public void renameTable(String tableName, String newTableName)
    {
        Console.WriteLine($"rename table from {tableName} to {newTableName}");
        // disini kode panjang
        // untuk eksekusi query rename table database
    }

    public void filterTable(String tableName, String fieldName, String orderType)
    {
        Console.WriteLine($"filter table {tableName} sort by {fieldName} {orderType}");
        // disini kode panjang
        // untuk eksekusi qeury filter data table
    }
}