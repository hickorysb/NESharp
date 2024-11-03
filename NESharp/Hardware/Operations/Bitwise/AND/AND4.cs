using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Absolute
public class AND4 : Instruction
{
    public const byte OPCODE = 0x2D;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        AND.AndMem(cpu, address);
        return 4;
    }
}