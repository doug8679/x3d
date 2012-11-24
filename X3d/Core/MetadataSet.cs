namespace X3d.Core
{
    using System.Collections.Generic;

    /// <summary>
    /// The metadata provided by this node is contained in the metadata nodes of 
    /// the value field.
    /// </summary>
    public class MetadataSet 
        : X3DMetadataObject<List<ChildContentModelCore>>, ChildContentModelCore
    {
    }
}
