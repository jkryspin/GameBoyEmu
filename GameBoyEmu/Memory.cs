namespace GameBoyEmu;

public class Memory
{
    private byte[] _mem;
    public Memory(byte[] memory)
    {
        _mem = memory;
    }

    public byte Read8(int position)
    {
        return _mem[position];
    }

    public int Length()
    {
        return _mem.Length;
    }
}