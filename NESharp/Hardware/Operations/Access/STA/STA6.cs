using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - (Indirect, X)
public class STA6 : Instruction
{
    public const byte OPCODE = 0x81;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(AddUShorts(offset, cpu.Registers.X.GetValue()));
        STA.StoreA(cpu, address);
        return 6;
    }
}