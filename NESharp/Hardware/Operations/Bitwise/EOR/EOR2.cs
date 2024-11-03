using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Zero Page
public class EOR2 : Instruction
{
    public const byte OPCODE = 0x45;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        EOR.XorA(cpu, zeroPageAddress);
        return 3;
    }
}