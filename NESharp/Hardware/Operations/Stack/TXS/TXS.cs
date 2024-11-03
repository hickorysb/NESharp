using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.TXS;

public class TXS : Instruction
{
    public const byte OPCODE = 0x9A;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.SP.SetValue(cpu.Registers.X.GetValue());
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.SP.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.SP.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}