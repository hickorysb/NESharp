using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

public class CMP3 : Instruction
{
    public const byte OPCODE = 0xD5;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        CMP.CompA(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 4;
    }
}