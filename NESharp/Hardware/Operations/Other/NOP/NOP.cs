using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Other.NOP;

public class NOP : Instruction
{
    public const byte OPCODE = 0xEA;
    
    public int Call(CPU cpu)
    {
        return 2;
    }
}