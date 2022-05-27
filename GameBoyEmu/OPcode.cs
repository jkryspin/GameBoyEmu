namespace GameBoyEmu;

public class OPcode
{
    public string Name;
    public ushort Length;
    public byte Value;
    public int TCycles;

    public OPcode(string name, ushort length, byte value, int cycles)
    {
        Name = name;
        Length = length;
        Value = value;
        TCycles = cycles;
    }
}