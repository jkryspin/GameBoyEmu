using GameBoyEmu.Util;

namespace GameBoyEmu.Processor;

public class Dissasembler
{
    public static string GetOpAsString(OPcode oPcode, Memory memory, ushort address)
    { 
        var val = oPcode;
        const string format = "{0,-18}; 0x{1,4}";
        const string format2 = "{0},${1}";
        return oPcode.Length switch
        {
            3 => string.Format(
                format, string.Format(format2, val.Name,
                   BitUtils.ToUnsigned16(memory.Read8(address + 2), memory.Read8(address+1)).ToString("x4")),
                address.ToString("x4")),
            2 => string.Format(format,
                string.Format(format2, val.Name,
                    memory.Read8(address + 1).ToString("x2")), address.ToString("x4")),
            _ => string.Format(format, val.Name, address.ToString("x4"))
        };
    }
}