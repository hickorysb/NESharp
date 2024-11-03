using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// Generic STA Code
public class STA
{
    public static void StoreA(CPU cpu, ushort address)
    {
        cpu.Motherboard.RAM.WriteByte(address, cpu.Registers.A.GetValue());
        if (Program.DEBUG_MODE) Console.WriteLine($"STA: A: 0x{cpu.Registers.A.GetValue():X2} MEM: 0x{cpu.Motherboard.RAM.ReadByte(address):X2} Address: 0x{address:X4}");
    }
}