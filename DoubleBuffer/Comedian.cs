namespace DoubleBuffer;

public class Comedian : Actor
{
    private Actor _facing;
    public Comedian(string name) : base(name) { }
    public void Face(Actor actor) => _facing = actor;
    public override void Update()
    {
        if (!WasSlapped()) return;
        Console.WriteLine(Name + " was slapped, so he slaps " + _facing.GetName());
        _facing.Slap();
    }

}