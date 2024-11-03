using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Zero Page
public class LDA2 : Instruction
{
    public const byte OPCODE = 0xA5;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDA.LoadA(cpu, zeroPageAddress);
        return 3;
    }
}