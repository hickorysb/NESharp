namespace NESharp.Hardware.Types;

public class Register8Bit
{
    private byte value;
    
    public byte GetValue() => value;
    
    public void SetValue(byte newValue) => value = newValue;

    public void Add(sbyte v)
    {
        sbyte val = (sbyte)value;
        val += v;
        value = (byte)val;
    }
    
    public byte Increment() => value++;

    public byte Increment(byte amount)
    { 
        byte original = value;
        value += amount;
        return original;
    }

    public byte Decrement() => value--;
    
    public byte Decrement(byte amount)
    { 
        byte original = value;
        value -= amount;
        return original;
    }
}