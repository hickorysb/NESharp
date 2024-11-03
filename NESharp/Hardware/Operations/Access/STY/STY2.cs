using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// STY - Zero Page, X
public class STY2 : Instruction
{
    public const byte OPCODE = 0x94;

    public int Call(CPU cpu)
    {
        ushort operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        STY.StoreY(cpu, AddUShorts(operand, cpu.Registers.X.GetValue()));
        return 4;
    }
}