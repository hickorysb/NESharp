using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

public class DEC3 : Instruction
{
    public const byte OPCODE = 0xCE;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        DEC.DecMem(cpu, address);
        return 6;
    }
}