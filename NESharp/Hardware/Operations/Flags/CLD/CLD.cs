using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.CLD;

public class CLD : Instruction
{
    public const byte OPCODE = 0xD8;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.D, false);
        return 2;
    }
}