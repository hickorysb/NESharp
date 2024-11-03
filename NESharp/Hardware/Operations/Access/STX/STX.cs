using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// Generic STX Code
public class STX
{
    public static void StoreX(CPU cpu, ushort address)
    {
        cpu.Motherboard.RAM.WriteByte(address, cpu.Registers.X.GetValue());
        if (Program.DEBUG_MODE) Console.WriteLine($"STX: X: 0x{cpu.Registers.X.GetValue():X2} MEM: 0x{cpu.Motherboard.RAM.ReadByte(address):X2} Address: 0x{address:X4}");
    }
}