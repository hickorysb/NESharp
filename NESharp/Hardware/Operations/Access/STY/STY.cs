using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// Generic STY Code
public class STY
{
    public static void StoreY(CPU cpu, ushort address)
    {
        cpu.Motherboard.RAM.WriteByte(address, cpu.Registers.Y.GetValue());
        
        if (Program.DEBUG_MODE) Console.WriteLine($"STY: Y: 0x{cpu.Registers.Y.GetValue():X2} MEM: 0x{cpu.Motherboard.RAM.ReadByte(address):X2} Address: 0x{address:X4}");
    }
}