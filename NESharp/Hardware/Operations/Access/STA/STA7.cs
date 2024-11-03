using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - (Indirect), Y
public class STA7 : Instruction
{
    public const byte OPCODE = 0x91;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(offset);
        STA.StoreA(cpu, AddUShorts(address, cpu.Registers.Y.GetValue()));
        return 6;
    }
}