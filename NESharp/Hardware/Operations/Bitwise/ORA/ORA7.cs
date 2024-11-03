using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - (Indirect, X)
public class ORA7 : Instruction
{
    public const byte OPCODE = 0x01;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(AddUShorts(offset, cpu.Registers.X.GetValue()));
        ORA.OrA(cpu, address);
        return 6;
    }
}