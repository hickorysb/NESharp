using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Zero Page, X
public class ORA3 : Instruction
{
    public const byte OPCODE = 0x15;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ORA.OrA(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 4;
    }
}