using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INC;

public class INC4 : Instruction
{
    public const byte OPCODE = 0xFE;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        INC.IncMem(cpu, AddUShorts(address, cpu.Registers.X.GetValue()));
        return 7;
    }
}