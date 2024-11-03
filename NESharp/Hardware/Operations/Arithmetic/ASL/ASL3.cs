using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL3 : Instruction
{
    public const byte OPCODE = 0x16;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort finalAddress = AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue());
        cpu.Motherboard.RAM.WriteByte(finalAddress, ASL.ShiftLeft(cpu, finalAddress));
        return 6;
    }
}