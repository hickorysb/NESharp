using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - Zero Page
public class CMP2 : Instruction
{
    public const byte OPCODE = 0xC5;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        CMP.CompA(cpu, zeroPageAddress);
        return 3;
    }
}