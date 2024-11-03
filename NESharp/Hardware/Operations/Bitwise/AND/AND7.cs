using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - (Indirect, X)
public class AND7 : Instruction
{
    public const byte OPCODE = 0x21;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(AddUShorts(offset, cpu.Registers.X.GetValue()));
        AND.AndMem(cpu, address);
        return 6;
    }
}