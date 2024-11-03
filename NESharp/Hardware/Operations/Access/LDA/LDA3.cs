using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Zero Page, X
public class LDA3 : Instruction
{
    public const byte OPCODE = 0xB5;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDA.LoadA(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 4;
    }
}