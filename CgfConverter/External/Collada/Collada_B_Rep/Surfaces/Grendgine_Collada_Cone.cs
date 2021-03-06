using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Cone
    {
        [XmlElement(ElementName = "radius")]
        public float Radius;

        [XmlElement(ElementName = "angle")]
        public float Angle;

        [XmlElement(ElementName = "extra")]
        public Grendgine_Collada_Extra[] Extra;
    }
}

