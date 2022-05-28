namespace GameBoyEmu;

public class Registers
{
    public byte a;
    public byte b;
    public byte c;
    public byte d;
    public byte e;
    public byte f;
    public byte h;
    private byte _l;
    public UInt16 pc { get; set; }

    public byte l
    {
        get => _l;
        set
        {
            _l = value;
            LFlags.Zero = IsEnableAtPosition(7);
            LFlags.Subtract = IsEnableAtPosition(6);
            LFlags.HalfCarry = IsEnableAtPosition(5);
            LFlags.Carry = IsEnableAtPosition(4);
        }
    }
    
    public FlagsRegister LFlags;

    private bool IsEnableAtPosition(ushort pos)
    {
        return (l >> pos & 0b1) != 0;
    }

    private ushort Get(byte b, byte c)
    {
        return (ushort) (b << 8 | c);
    }

    private void Set(ushort value, ref byte b, ref byte c)
    {
        b = (byte) ((value & 0xFF00) >> 8);
        c = (byte) (value & 0xFF);
    }

    public void SetAF(ushort value)
    {
        Set(value, ref a, ref f);
    }

    public void SetBC(ushort value)
    {
        Set(value, ref b, ref c);
    }
    
    public void SetDE(ushort value)
    {
        Set(value, ref d, ref e);
    }
    
    public void SetHL(ushort value)
    {
        h = (byte) ((value & 0xFF00) >> 8);
        l = (byte) (value & 0xFF);
    }
    
    public ushort GetAF()
    {
        return Get(a, f);
    }

    public ushort GetBC()
    {
        return Get(b, c);
    }

    public ushort GetDE()
    {
        return Get(d, e);
    }
    

    public ushort HL
    {
        get => Get(h, l);
        set => Set(value, ref h, ref _l);
    }
}

public struct FlagsRegister
{
    public bool Zero;
    public bool Subtract;
    public bool HalfCarry;
    public bool Carry;
}
