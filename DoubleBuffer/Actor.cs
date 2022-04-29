using System.Runtime.CompilerServices;

namespace DoubleBuffer;

public abstract class Actor
{
    protected readonly string Name;
    
    private bool _currentSlapped;
    private bool _nextSlapped;

    protected Actor(string name)
    {
        Name = name;
    }

    public abstract void Update();

    public void Swap()
    {
        _currentSlapped = _nextSlapped;
        _nextSlapped = false;
    }

    public void Slap() => _nextSlapped = true;
    

    public string GetName() => Name;

    public bool WasSlapped() => _currentSlapped;
}