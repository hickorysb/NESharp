using NESharp.Hardware.Types;

namespace NESharp.Hardware;

public class APU : CycleBasedComponent
{
    public Motherboard Motherboard;
    
    public APU(Motherboard attachedMotherboard)
    {
        Motherboard = attachedMotherboard;
    }
    
    protected override int ThreadLoop()
    {
        throw new NotImplementedException();
    }
}