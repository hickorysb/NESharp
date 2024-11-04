using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// Generic STY Code
public class STY
{
    public static void StoreY(ushort address)
    {
        Motherboard.RAM.WriteByte(address, Motherboard.CPU.Registers.Y.GetValue());
        
        if (Program.DEBUG_MODE) Console.WriteLine($"STY: Y: 0x{Motherboard.CPU.Registers.Y.GetValue():X2} MEM: 0x{Motherboard.RAM.ReadByte(address):X2} Address: 0x{address:X4}");
    }
}