namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml;

    public class ExternProtoDeclare : X3DPrototype, ChildContentModelSceneGraphStructure
    {
        public List<Field> Fields { get; set; }

        public MFString URL { get; set; }

        public SFString AppInfo { get; set; }

        public SFString Documentation { get; set; }

        public void Write(XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}
