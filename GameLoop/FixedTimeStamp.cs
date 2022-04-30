using System.Diagnostics;

namespace GameLoop;

public class FixedTimeStamp
{
    private const double MsPerUpdate = 1.0 / 60;
    public void RunGameLoop()
    {
        var previous = GetCurrentTime();
        var lag = 0.0;
        while (true)
        {
            var current = GetCurrentTime();
            var elapsed = current - previous;
            previous = elapsed;
            lag += elapsed;
            
            // ProcessInput();

            while (lag >= MsPerUpdate)
            {
                // Update();
                lag -= MsPerUpdate;
            }
            
            // Render();
        }
    }

    private static double GetCurrentTime()
    {
        return Process.GetCurrentProcess().StartTime.Millisecond / 1000.0;
    }
}