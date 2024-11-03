using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PLA;

public class PLA : Instruction
{
    public const byte OPCODE = 0x68;

    public int Call(CPU cpu)
    {
        byte status = cpu.Motherboard.RAM.Pop();
        cpu.Registers.A.SetValue(status);
        return 4;
    }
}