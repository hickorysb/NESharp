using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

public class CMP3 : Instruction
{
    public const byte OPCODE = 0xD5;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;
    
    public override int Call(ushort address)
    {
        CMP.CompA(address);
        return 4;
    }
}