using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL1 : Instruction
{
    public const byte OPCODE = 0x0A;

    public int Call(CPU cpu)
    {
        cpu.Registers.A.SetValue(ASL.ShiftLeft(cpu, cpu.Registers.A.GetValue()));
        return 2;
    }
}