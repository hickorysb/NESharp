using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL1 : Instruction
{
    public const byte OPCODE = 0x2A;

    public int Call(CPU cpu)
    {
        cpu.Registers.A.SetValue(ROL.RotateLeft(cpu, cpu.Registers.A.GetValue()));
        return 2;
    }
}