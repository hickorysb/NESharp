using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Transfer.TYA;

public class TYA : Instruction
{
    public const byte OPCODE = 0x98;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.A.SetValue(cpu.Registers.Y.GetValue());
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.A.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.A.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}