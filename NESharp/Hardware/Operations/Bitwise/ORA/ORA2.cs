using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Zero Page
public class ORA2 : Instruction
{
    public const byte OPCODE = 0x05;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ORA.OrA(cpu, zeroPageAddress);
        return 3;
    }
}