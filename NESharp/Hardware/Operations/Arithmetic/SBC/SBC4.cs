using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Absolute
public class SBC4 : Instruction
{
    public const byte OPCODE = 0xED;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        SBC.SubA(cpu, address);
        return 4;
    }
}