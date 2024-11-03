using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INY;

public class INY : Instruction
{
    public const byte OPCODE = 0xC8;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.Y.Increment();
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.Y.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.Y.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}