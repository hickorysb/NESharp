using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR5 : Instruction
{
    public const byte OPCODE = 0x7E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, cpu.Registers.X.GetValue());
        cpu.Motherboard.RAM.WriteByte(finalAddress, ROR.RotateRight(cpu, finalAddress));
        return 7;
    }
}