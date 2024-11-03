using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Transfer.TXA;

public class TXA : Instruction
{
    public const byte OPCODE = 0x8A;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.A.SetValue(cpu.Registers.X.GetValue());
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.A.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.A.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}