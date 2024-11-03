using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INC;

public class INC2 : Instruction
{
    public const byte OPCODE = 0xF6;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        INC.IncMem(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 6;
    }
}