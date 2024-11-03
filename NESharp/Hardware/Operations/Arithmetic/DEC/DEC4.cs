using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

public class DEC4 : Instruction
{
    public const byte OPCODE = 0xDE;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        DEC.DecMem(cpu, AddUShorts(address, cpu.Registers.X.GetValue()));
        return 7;
    }
}