namespace NESharp.Hardware.Types;

public class Register16Bit
{
    private ushort value;
    
    public ushort GetValue() => value;
    
    public void SetValue(ushort newValue) => value = newValue;

    public void Add(sbyte v)
    {
        short val = (short)value;
        val += v;
        value = (ushort)val;
    }
    
    public ushort Increment() => value++;
    
    public ushort Increment(ushort amount)
    { 
        ushort original = value;
        value += amount;
        return original;
    }
    
    public ushort Decrement() => value--;
    
    public ushort Decrement(ushort amount)
    { 
        ushort original = value;
        value -= amount;
        return original;
    }
}