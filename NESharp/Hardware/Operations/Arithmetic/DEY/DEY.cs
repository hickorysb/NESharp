using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEY;

public class DEY : Instruction
{
    public const byte OPCODE = 0x88;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.Y.Decrement();
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.Y.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.Y.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}