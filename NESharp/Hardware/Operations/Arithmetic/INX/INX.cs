using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INX;

public class INX : Instruction
{
    public const byte OPCODE = 0xE8;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.X.Increment();
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.X.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.X.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}