using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

public class DEC2 : Instruction
{
    public const byte OPCODE = 0xD6;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        DEC.DecMem(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 6;
    }
}