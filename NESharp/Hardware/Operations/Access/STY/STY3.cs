using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// STY - Absolute
public class STY3 : Instruction
{
    public const byte OPCODE = 0x8C;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        STY.StoreY(cpu, address);
        return 4;
    }
}