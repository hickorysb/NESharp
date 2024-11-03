using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.CLV;

public class CLV : Instruction
{
    public const byte OPCODE = 0xB8;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.V, false);
        return 2;
    }
}