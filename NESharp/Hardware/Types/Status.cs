namespace NESharp.Hardware.Types;

public class Status
{
    public bool Carry; // bit 0
    public bool Zero; // bit 1
    public bool DisableInterrupts; // bit 2
    public bool DecimalMode; // bit 3
    public bool Break; // bit 4
    private const byte UNUSED = 1; // bit 5 
    public bool Overflow; // bit 6
    public bool Negative; // bit 7

    public byte BuildByte()
    {
        byte result = 0;

        if (Carry) result |= 1 << 0;
        if (Zero) result |= 1 << 1;
        if (DisableInterrupts) result |= 1 << 2;
        if (DecimalMode) result |= 1 << 3;
        if (Break) result |= 1 << 4;
        
        result |= UNUSED << 5; // bit 5 is always set to 1
        
        if (Overflow) result |= 1 << 6;
        if (Negative) result |= 1 << 7;

        return result;
    }
    
    public void ParseByte(byte input)
    {
        Carry = (input & (1 << 0)) != 0;
        Zero = (input & (1 << 1)) != 0;
        DisableInterrupts = (input & (1 << 2)) != 0;
        DecimalMode = (input & (1 << 3)) != 0;

        Overflow = (input & (1 << 6)) != 0;
        Negative = (input & (1 << 7)) != 0;
    }

    public void Reset()
    {
        Carry = false;
        Zero = false;
        DisableInterrupts = false;
        DecimalMode = false;
        Break = false;
        Overflow = false;
        Negative = false;
    }

    public void SetBit(StatusBit bit, bool value)
    {
        switch (bit)
        {
            case StatusBit.C:
                Carry = value;
                break;
            case StatusBit.Z:
                Zero = value;
                break;
            case StatusBit.I:
                DisableInterrupts = value;
                break;
            case StatusBit.D:
                DecimalMode = value;
                break;
            case StatusBit.B:
                Break = value;
                break;
            case StatusBit.U:
                Console.WriteLine("THIS BIT IS NOT USED!!!!");
                break;
            case StatusBit.V:
                Overflow = value;
                break;
            case StatusBit.N:
                Negative = value;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(bit), bit, null);
        }
    }
}