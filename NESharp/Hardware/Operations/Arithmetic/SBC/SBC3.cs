using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Zero Page, X
public class SBC3 : Instruction
{
    public const byte OPCODE = 0xF5;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        SBC.SubA(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 4;
    }
}