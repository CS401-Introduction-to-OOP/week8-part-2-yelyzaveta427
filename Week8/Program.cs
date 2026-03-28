
using Week8;

class Program
{
    public static void Main()
    {
        var fileRes = new FileResource("Document");
        var netRes = new NetworkResource("123.234.123.12");

        var manager = new ResourceManager<Resource>();
        manager.Add(fileRes);
        manager.Add(netRes);
        
        manager.OpenAll();
        using(var res = new FileResource("math"))
        {
            res.Open();
        }
        
        manager.CloseAll();
    }
    
}