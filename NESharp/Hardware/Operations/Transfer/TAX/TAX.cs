using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Transfer.TAX;

public class TAX : Instruction
{
    public const byte OPCODE = 0xAA;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.X.SetValue(cpu.Registers.A.GetValue());
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.X.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.X.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}