using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR3 : Instruction
{
    public const byte OPCODE = 0x56;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort finalAddress = AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue());
        cpu.Motherboard.RAM.WriteByte(finalAddress, LSR.ShiftRight(cpu, finalAddress));
        return 6;
    }
}