namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class MetadataSet : X3DMetadataObject, ChildContentModelCore
    {
        [XmlElement]
        public List<ChildContentModelCore> ChildMetadata { get; set; }
    }
}
