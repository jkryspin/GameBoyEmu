namespace GameBoyEmu;

public class Cpu
{
   private Registers _registers = new Registers();
   private Dictionary<ushort, OPcode> _opCodes = new Dictionary<ushort, OPcode>();
   private OPcodesHandler _OPcodesHandler = new OPcodesHandler();
   private CB_OPcodesHandler _CB_OPcodesHandler = new CB_OPcodesHandler();
   
   

   public Cpu()
   {
      var rom = File.ReadAllBytes("./DMG_ROM.bin");
      _registers.pc = 0x00;

      while (_registers.pc < 0xFFFF)
      {
         Console.WriteLine(_registers.pc);
         Execute((ushort) rom[_registers.pc]);
      }
   }
   public void Execute(ushort opCode)
   {
      _OPcodesHandler.OPcodes.TryGetValue(opCode, out var val);
      Console.WriteLine(val.Name);
      _registers.pc += val.Length;
   }

  
}