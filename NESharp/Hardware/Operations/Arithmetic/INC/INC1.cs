using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INC;

public class INC1 : Instruction
{
    public const byte OPCODE = 0xE6;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        INC.IncMem(cpu, zeroPageAddress);
        return 5;
    }
}