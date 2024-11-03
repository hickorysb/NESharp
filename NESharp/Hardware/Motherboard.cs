using System.Diagnostics;

namespace NESharp.Hardware;

public class Motherboard
{
    public readonly CPU CPU;
    public readonly PPU PPU;
    public readonly APU APU;
    public readonly RAM RAM;

    public Motherboard()
    {
        CPU = new CPU(this);
        PPU = new PPU(this);
        APU = new APU(this);
        RAM = new RAM(this);
        RAM.TempFill();
        RAM.WriteShort(0xFFFC, 0x0600);
        CPU.ResetState();
        CPU.StartThread();
    }

    public void Stop()
    {
        CPU.StopThread();
        PPU.StopThread();
        APU.StopThread();
    }
}