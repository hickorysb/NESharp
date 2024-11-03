using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.CLC;

public class CLC : Instruction
{
    public const byte OPCODE = 0x18;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.C, false);
        return 2;
    }
}