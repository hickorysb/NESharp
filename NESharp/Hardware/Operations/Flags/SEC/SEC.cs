using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.SEC;

public class SEC : Instruction
{
    public const byte OPCODE = 0x38;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.C, true);
        return 2;
    }
}