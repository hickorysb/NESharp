using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEX;

public class DEX : Instruction
{
    public const byte OPCODE = 0xCA;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.X.Decrement();
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.X.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.X.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}