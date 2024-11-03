using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX - Zero Page
public class CPX2 : Instruction
{
    public const byte OPCODE = 0xE4;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        CPX.CompX(cpu, zeroPageAddress);
        return 3;
    }
}