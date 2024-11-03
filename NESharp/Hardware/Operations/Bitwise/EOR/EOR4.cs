using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Absolute
public class EOR4 : Instruction
{
    public const byte OPCODE = 0x4D;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        EOR.XorA(cpu, address);
        return 4;
    }
}