using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Transfer.TAY;

public class TAY : Instruction
{
    public const byte OPCODE = 0xA8;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.Y.SetValue(cpu.Registers.A.GetValue());
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.Y.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.Y.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}