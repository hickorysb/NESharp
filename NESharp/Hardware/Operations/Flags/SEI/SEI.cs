using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.SEI;

public class SEI : Instruction
{
    public const byte OPCODE = 0x78;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.I, false);
        return 2;
    }
}