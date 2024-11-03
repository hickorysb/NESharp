using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.TSX;

public class TSX : Instruction
{
    public const byte OPCODE = 0xBA;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.X.SetValue(cpu.Registers.SP.GetValue());
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.X.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.X.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}