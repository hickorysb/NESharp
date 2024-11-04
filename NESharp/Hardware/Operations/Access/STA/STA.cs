using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// Generic STA Code
public class STA
{
    public static void StoreA(ushort address)
    {
        Motherboard.RAM.WriteByte(address, Motherboard.CPU.Registers.A.GetValue());
        if (Program.DEBUG_MODE) Console.WriteLine($"STA: A: 0x{Motherboard.CPU.Registers.A.GetValue():X2} MEM: 0x{Motherboard.RAM.ReadByte(address):X2} Address: 0x{address:X4}");
    }
}