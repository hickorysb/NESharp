using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR3 : Instruction
{
    public const byte OPCODE = 0x76;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort finalAddress = AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue());
        cpu.Motherboard.RAM.WriteByte(finalAddress, ROR.RotateRight(cpu, finalAddress));
        return 6;
    }
}