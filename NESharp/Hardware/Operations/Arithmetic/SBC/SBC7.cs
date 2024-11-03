using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - (Indirect, X)
public class SBC7 : Instruction
{
    public const byte OPCODE = 0xE1;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(AddUShorts(offset, cpu.Registers.X.GetValue()));
        SBC.SubA(cpu, address);
        return 6;
    }
}