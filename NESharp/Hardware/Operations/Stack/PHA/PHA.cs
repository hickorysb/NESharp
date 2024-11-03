using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PHA;

public class PHA : Instruction
{
    public const byte OPCODE = 0x48;

    public int Call(CPU cpu)
    {
        cpu.Motherboard.RAM.Push(cpu.Registers.A.GetValue());
        return 3;
    }
}