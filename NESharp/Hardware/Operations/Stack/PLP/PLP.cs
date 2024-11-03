using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PLP;

public class PLP : Instruction
{
    public const byte OPCODE = 0x28;

    public int Call(CPU cpu)
    {
        byte status = cpu.Motherboard.RAM.Pop();
        cpu.Registers.P.ParseByte(status);
        return 4;
    }
}