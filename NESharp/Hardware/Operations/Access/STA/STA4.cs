using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Absolute, X
public class STA4 : Instruction
{
    public const byte OPCODE = 0x9D;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        STA.StoreA(cpu, AddUShorts(address, cpu.Registers.X.GetValue()));
        return 5;
    }
}