using avaloni.Models;

namespace avaloni;

public class Service
{
    private static ResourceContext? _db;

    public static ResourceContext GetDbContext()
    {
        if (_db == null)
        {
            _db = new ResourceContext();
        }

        return _db;
    }
}