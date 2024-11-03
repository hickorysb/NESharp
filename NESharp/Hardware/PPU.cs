using NESharp.Hardware.Types;

namespace NESharp.Hardware;

public class PPU : CycleBasedComponent
{
    public Motherboard Motherboard;
    
    protected override double Frequency { get; } = 5_370_000;

    public PPU(Motherboard attachedMotherboard)
    {
        Motherboard = attachedMotherboard;
    }
    
    protected override int ThreadLoop()
    {
        throw new NotImplementedException();
    }
}