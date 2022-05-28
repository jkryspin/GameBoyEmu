namespace GameBoyEmu;

public delegate void Step();
public class OPcode
{
    public string Name;
    public ushort Length;
    public byte Value;
    public Step[] steps;
    public int TCycles;

    public OPcode(string name, ushort length, byte value, int cycles, Step[] steps = null)
    {
        Name = name;
        Length = length;
        Value = value;
        TCycles = cycles;
        this.steps = steps;
    }
}