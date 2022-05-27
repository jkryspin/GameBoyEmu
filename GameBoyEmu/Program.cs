// See https://aka.ms/new-console-template for more information


using System.Text.Json;
using System.Text.Json.Serialization;
using GameBoyEmu;


Console.WriteLine("Hello, World!");

var cpu = new Cpu();
return;
var text = File.ReadAllText("dmgops.json");

var root =JsonSerializer.Deserialize<Root>(text);
var pog = root.Unprefixed[0].Name;

var i = 0;
// var items = root.Unprefixed;
var items = root.CBPrefixed;
while (i < items.Count)
{
    var stringy=  i.ToString("x2");
    Console.Write(
         "{0x" + stringy + ", new OPcode(\"" + items[i].Name + "\"" + "," + items[i].Length + ",0,4)},"
         );
    i++;
}