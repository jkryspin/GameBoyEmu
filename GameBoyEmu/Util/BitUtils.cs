namespace GameBoyEmu.Util;

public static class BitUtils
{
    public static ushort ToUnsigned16(byte msb, byte lsb)
    {
        return (ushort) ((msb << 8) | lsb);
    }
}