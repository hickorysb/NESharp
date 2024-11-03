using System.Diagnostics;

namespace NESharp.Hardware.Types;

public abstract class CycleBasedComponent
{
    private Thread thread;
    private Stopwatch stopwatch;
    protected bool stopFlag = false;
    protected virtual double Frequency { get; }
    protected virtual double DebugFrequency { get; }
    private readonly double Interval;

    protected CycleBasedComponent()
    {
        thread = new Thread(WrapperLoop);
        stopwatch = Stopwatch.StartNew();
        double intervalNanoseconds = 1e9 / (Frequency * 1e6);
        if (Program.DEBUG_MODE) intervalNanoseconds = 1e9 / (DebugFrequency * 1e6);
        Interval = intervalNanoseconds * Stopwatch.Frequency / 1e9;
    }

    private void WrapperLoop()
    {
        long nextTick = stopwatch.ElapsedTicks;
        stopwatch.Start();
        Console.WriteLine($"Interval: {Interval}");
        while (!stopFlag)
        {
            if (stopwatch.ElapsedTicks < nextTick) continue;
            //if (Program.DEBUG_MODE) stopwatch.Stop();
            int instructionCycles = ThreadLoop();
            nextTick += ((long) Interval * instructionCycles);
        }
    }

    protected abstract int ThreadLoop();
    
    public void StartThread() => thread.Start();
    
    public void StopThread() => stopFlag = true;

    public void Pause() => stopwatch.Stop();
    
    public void Resume() => stopwatch.Start();
    
    public void Reset() => stopFlag = false;
}