using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL3 : Instruction
{
    public const byte OPCODE = 0x36;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort finalAddress = AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue());
        cpu.Motherboard.RAM.WriteByte(finalAddress, ROL.RotateLeft(cpu, finalAddress));
        return 6;
    }
}