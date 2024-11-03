using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// STA - Absolute
public class STX3 : Instruction
{
    public const byte OPCODE = 0x8E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        STX.StoreX(cpu, address);
        return 4;
    }
}