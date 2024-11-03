using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY - Zero Page
public class CPY2 : Instruction
{
    public const byte OPCODE = 0xC4;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        CPY.CompY(cpu, zeroPageAddress);
        return 3;
    }
}