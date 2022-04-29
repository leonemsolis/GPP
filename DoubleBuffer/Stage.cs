namespace DoubleBuffer;

public class Stage
{
    private const int NumActors = 3;
    private Actor[] _actors = new Actor[3];
    
    public void Add(Actor actor, int index)
    {
        _actors[index] = actor;
    }

    public void Update()
    {
        for (int i = 0; i < NumActors; i++)
        {
            _actors[i].Update();
        }
        for (int i = 0; i < NumActors; i++)
        {
            _actors[i].Swap();
        }
        
    }
}