using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Directional
    {
        [XmlElement(ElementName = "color")]
        public Grendgine_Collada_Color Color;

    }
}

