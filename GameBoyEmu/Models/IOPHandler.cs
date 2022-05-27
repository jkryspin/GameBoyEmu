namespace GameBoyEmu.Models;

public abstract class IOPHandler
{
   public Dictionary<ushort, OPcode> OPcodes;

   public  abstract Dictionary<ushort, OPcode> InitOpcodes();
}