using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Absolute, X
public class STA5 : Instruction
{
    public const byte OPCODE = 0x99;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        STA.StoreA(cpu, AddUShorts(address, cpu.Registers.Y.GetValue()));
        return 5;
    }
}