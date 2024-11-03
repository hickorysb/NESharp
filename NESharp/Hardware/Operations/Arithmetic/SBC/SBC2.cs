using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Zero Page
public class SBC2 : Instruction
{
    public const byte OPCODE = 0xE5;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        SBC.SubA(cpu, zeroPageAddress);
        return 3;
    }
}