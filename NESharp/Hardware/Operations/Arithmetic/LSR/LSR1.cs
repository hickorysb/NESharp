using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR1 : Instruction
{
    public const byte OPCODE = 0x4A;

    public int Call(CPU cpu)
    {
        cpu.Registers.A.SetValue(LSR.ShiftRight(cpu, cpu.Registers.A.GetValue()));
        return 2;
    }
}