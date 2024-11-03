using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.CLI;

public class CLI : Instruction
{
    public const byte OPCODE = 0x58;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.I, false);
        return 2;
    }
}