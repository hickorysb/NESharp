using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.SED;

public class SED : Instruction
{
    public const byte OPCODE = 0xF8;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.D, true);
        return 2;
    }
}