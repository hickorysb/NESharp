using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// STX - Zero Page, Y
public class STX2 : Instruction
{
    public const byte OPCODE = 0x96;

    public int Call(CPU cpu)
    {
        ushort operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        STX.StoreX(cpu, AddUShorts(operand, cpu.Registers.Y.GetValue()));
        return 4;
    }
}