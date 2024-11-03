using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR1 : Instruction
{
    public const byte OPCODE = 0x6A;

    public int Call(CPU cpu)
    {
        cpu.Registers.A.SetValue(ROR.RotateRight(cpu, cpu.Registers.A.GetValue()));
        return 2;
    }
}