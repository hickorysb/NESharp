using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Zero Page
public class AND2 : Instruction
{
    public const byte OPCODE = 0x25;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        AND.AndMem(cpu, zeroPageAddress);
        return 3;
    }
}