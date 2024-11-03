using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Zero Page, X
public class STA2 : Instruction
{
    public const byte OPCODE = 0x95;

    public int Call(CPU cpu)
    {
        ushort operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        STA.StoreA(cpu, AddUShorts(operand, cpu.Registers.X.GetValue()));
        return 4;
    }
}