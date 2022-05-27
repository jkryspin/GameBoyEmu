// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class CBPrefixed
{
    public string Name { get; set; }
    public string Group { get; set; }
    public int TCyclesBranch { get; set; }
    public int TCyclesNoBranch { get; set; }
    public int Length { get; set; }
    public Flags Flags { get; set; }
    public List<TimingNoBranch> TimingNoBranch { get; set; }
}

public class Flags
{
    public string Z { get; set; }
    public string N { get; set; }
    public string H { get; set; }
    public string C { get; set; }
}

public class Root
{
    public List<Unprefixed> Unprefixed { get; set; }
    public List<CBPrefixed> CBPrefixed { get; set; }
}

public class TimingBranch
{
    public string Type { get; set; }
    public string Comment { get; set; }
}

public class TimingNoBranch
{
    public string Type { get; set; }
    public string Comment { get; set; }
}

public class Unprefixed
{
    public string Name { get; set; }
    public string Group { get; set; }
    public int TCyclesBranch { get; set; }
    public int TCyclesNoBranch { get; set; }
    public int Length { get; set; }
    public Flags Flags { get; set; }
    public List<TimingNoBranch> TimingNoBranch { get; set; }
    public List<TimingBranch> TimingBranch { get; set; }
}