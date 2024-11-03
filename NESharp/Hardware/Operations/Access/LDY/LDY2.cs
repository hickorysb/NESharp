using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Zero Page
public class LDY2 : Instruction
{
    public const byte OPCODE = 0xA4;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDY.LoadY(cpu, zeroPageAddress);
        return 3;
    }
}