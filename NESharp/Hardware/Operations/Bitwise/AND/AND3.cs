using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Zero Page, X
public class AND3 : Instruction
{
    public const byte OPCODE = 0x35;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        AND.AndMem(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 4;
    }
}