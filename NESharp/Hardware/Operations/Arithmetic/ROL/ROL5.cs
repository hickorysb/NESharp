using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL5 : Instruction
{
    public const byte OPCODE = 0x3E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, cpu.Registers.X.GetValue());
        cpu.Motherboard.RAM.WriteByte(finalAddress, ROL.RotateLeft(cpu, finalAddress));
        return 7;
    }
}