namespace Latihan4;

public class TestEncapsulation
{
    public static void Main()
    {
        GameLabDB db = new GameLabDB();
        db.opeConnection();
        db.renameTable("tbl_karyawan", "tbl_employee");
        db.filterTable("tbl_employee", "kode", "ASC");
        db.closeConnection();
    }
}