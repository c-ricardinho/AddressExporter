using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressExporter
{
    class PropertiesClass
    {
        public string name { get; set; }
        public object description { get; set; }
        public string TerritoryType { get; set; }
        public object TerritoryTypeCode { get; set; }
        public string TerritoryTypeColor { get; set; }
        public string TerritoryNumber { get; set; }
        public object TerritoryNotes { get; set; }
    }

    class GeometryClass
    {
        public string type { get; set; }
        public List<List<List<double>>> coordinates { get; set; }
    }

    class FeatureClass
    {
        public string type { get; set; }
        public PropertiesClass properties { get; set; }
        public GeometryClass geometry { get; set; }
    }

    class RootObject
    {
        public string type { get; set; }
        public List<FeatureClass> features { get; set; }
    }
}
