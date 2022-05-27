namespace GameBoyEmu;

public class Cpu
{
   private Registers _registers = new Registers();
   private Dictionary<ushort, OPcode> _opCodes = new Dictionary<ushort, OPcode>();
   private OPcodesHandler _OPcodesHandler = new OPcodesHandler();
   private CbOPcodesHandler _CB_OPcodesHandler = new CbOPcodesHandler();
   private byte[] rom;
   
   

   public Cpu()
   {
      rom = File.ReadAllBytes("./DMG_ROM.bin");
      _registers.pc = 0x00;

      while (_registers.pc < 0xFFFF)
      {
         // Console.WriteLine(_registers.pc);
         Execute((ushort) rom[_registers.pc]);
      }
   }
   
   public void Execute(ushort opCode)
   {
      _OPcodesHandler.OPcodes.TryGetValue(opCode, out var val);
      if (val.Name == "PREFIX CB")
      {
         _CB_OPcodesHandler.OPcodes.TryGetValue((ushort) rom[_registers.pc + 1], out val);
         _registers.pc++;
      }
      // Console.WriteLine(val.Name +"; " + "0x" + _registers.pc.ToString("x4") );
      var tolog = $"{val.Name,-15}; 0x{_registers.pc.ToString("x4"),4}";
      Console.WriteLine(tolog);
      _registers.pc += val.Length;
   }

  
}