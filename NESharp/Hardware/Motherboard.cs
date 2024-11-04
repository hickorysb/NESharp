using System.Diagnostics;

namespace NESharp.Hardware;

public class Motherboard
{
    public static CPU CPU { get; private set; }
    public static PPU PPU { get; private set; }
    public static APU APU { get; private set; }
    public static RAM RAM { get; private set; }

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