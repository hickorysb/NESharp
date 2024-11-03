using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR4 : Instruction
{
    public const byte OPCODE = 0x6E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        cpu.Motherboard.RAM.WriteByte(address, ROR.RotateRight(cpu, address));
        return 6;
    }
}