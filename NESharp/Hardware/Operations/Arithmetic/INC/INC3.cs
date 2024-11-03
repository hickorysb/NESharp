using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INC;

public class INC3 : Instruction
{
    public const byte OPCODE = 0xEE;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        INC.IncMem(cpu, address);
        return 6;
    }
}