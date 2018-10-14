using System;

public class Properties
{
    public string name { get; set; }
    public object description { get; set; }
    public string TerritoryType { get; set; }
    public object TerritoryTypeCode { get; set; }
    public string TerritoryTypeColor { get; set; }
    public string TerritoryNumber { get; set; }
    public object TerritoryNotes { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public List<List<List<double>>> coordinates { get; set; }
}

public class Feature
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }
}

public class RootObject
{
    public string type { get; set; }
    public List<Feature> features { get; set; }
}
