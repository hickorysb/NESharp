using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// Generic STX Code
public class STX
{
    public static void StoreX(ushort address)
    {
        Motherboard.RAM.WriteByte(address, Motherboard.CPU.Registers.X.GetValue());
        if (Program.DEBUG_MODE) Console.WriteLine($"STX: X: 0x{Motherboard.CPU.Registers.X.GetValue():X2} MEM: 0x{Motherboard.RAM.ReadByte(address):X2} Address: 0x{address:X4}");
    }
}