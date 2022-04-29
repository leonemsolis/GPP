namespace DoubleBuffer;

internal static class Program
{
    private static void Main(string []args)
    {
        var stage = new Stage();

        var harry = new Comedian("Harry");
        var baldy = new Comedian("Baldy");
        var chump = new Comedian("Chump");
        
        harry.Face(baldy);
        baldy.Face(chump);
        chump.Face(harry);
        
        stage.Add(harry, 2);
        stage.Add(baldy, 1);
        stage.Add(chump, 0);
        
        harry.Slap();
        while (true)
        {
            stage.Update();
            if (Console.ReadKey().KeyChar == ' ') continue;
            else break;
        }
    }
}