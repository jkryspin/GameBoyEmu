using GameBoyEmu.Processor;

namespace GameBoyEmu;

public class Cpu
{
    private Registers _registers = new Registers();
    private Dictionary<ushort, OPcode> _opCodes = new Dictionary<ushort, OPcode>();
    private OPcodesHandler _OPcodesHandler;
    private CbOPcodesHandler _CB_OPcodesHandler;
    private Memory _memory;


    public Cpu()
    {
        _CB_OPcodesHandler = new CbOPcodesHandler(_registers);
        _memory = new Memory(File.ReadAllBytes("./DMG_ROM.bin"));
        _OPcodesHandler = new OPcodesHandler(_registers, _memory);
        _registers.pc = 0x00;

        while (_registers.pc < _memory.Length())
        {
            // Console.WriteLine(_registers.pc);
            Execute((ushort) _memory.Read8(_registers.pc));
        }
    }

    public void Execute(ushort opCode)
    {
        _OPcodesHandler.OPcodes.TryGetValue(opCode, out var val);
        if (val.Name == "PREFIX CB")
        {
            Console.WriteLine("IN CB");
            _CB_OPcodesHandler.OPcodes.TryGetValue((ushort) _memory.Read8(_registers.pc + 1), out val);
        }

        var toLog = Dissasembler.GetOpAsString(val, _memory, _registers.pc);
        Console.WriteLine(toLog);
        _registers.pc += val.Length;
    }
}