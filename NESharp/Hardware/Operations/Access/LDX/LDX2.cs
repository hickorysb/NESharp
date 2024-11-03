using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Zero Page
public class LDX2 : Instruction
{
    public const byte OPCODE = 0xA6;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDX.LoadX(cpu, zeroPageAddress);
        return 3;
    }
}