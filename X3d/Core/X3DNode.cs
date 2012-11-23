namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class X3DNode
    {
        [XmlElement(ElementName = "IS", IsNullable = true, Order = 0)]
        public IS IS { get; set; }

        [XmlElement(ElementName = "metadata", IsNullable = true, Order = 1)]
        public ChildContentModelCore Metadata { get; set; }

        [XmlAttribute]
        public NameToken DEF { get; set; }

        [XmlAttribute]
        public NameToken USE { get; set; }

        [XmlAttribute(AttributeName = "containerField")]
        public SFString ContainerField { get; set; }
    }

    public abstract class X3DPrototypeInstance : X3DNode
    {
    }

    public abstract class X3DChildNode : X3DNode
    {
    }

    public abstract class X3DBindableNode : X3DChildNode
    {
        public void SetBind(SFBool obj)
        {
        }

        public SFTime BindTime { get; protected set; }

        public SFBool IsBound { get; protected set; }
    }

    public abstract class X3DInfoNode : X3DChildNode
    {
    }

    public abstract class X3DSensorNode : X3DChildNode
    {
        public SFBool Enabled { get; set; }

        public SFBool IsActive { get; protected set; }
    }

    public class WorldInfo : X3DInfoNode
    {
        public MFString Info { get; set; }

        public SFString Title { get; set; }
    }

    public class Color : SceneGraphFragmentContentModel
    {
    }

    public class ColorRGBA : SceneGraphFragmentContentModel
    {
    }

    public class Coordinate : SceneGraphFragmentContentModel
    {
        
    }
    public class CoordinateDouble : SceneGraphFragmentContentModel
    {
        
    }
    public class FontStyle : SceneGraphFragmentContentModel
    {
        
    }
    public class ScreenFontStyle : SceneGraphFragmentContentModel
    {
        
    }
    public class GeoCoordinate : SceneGraphFragmentContentModel
    {
        
    }
    public class Normal : SceneGraphFragmentContentModel
    {
        
    }
    public class TextureCoordinate : SceneGraphFragmentContentModel
    {
        
    }
    public class HAnimDisplacer : SceneGraphFragmentContentModel
    {
        
    }
    public class Contour2D : SceneGraphFragmentContentModel
    {
        
    }
    public class ContourPolyline2D : SceneGraphFragmentContentModel
    {
        
    }
    public class NurbsTextureCoordinate : SceneGraphFragmentContentModel
    {
        
    }
    public class Layer : SceneGraphFragmentContentModel
    {
        
    }
    public class LayoutLayer : SceneGraphFragmentContentModel
    {
        
    }
    public class Viewport : SceneGraphFragmentContentModel
    {
        
    }
    public class BallJoint : SceneGraphFragmentContentModel
    {
        
    }
    public class CollidableOffset : SceneGraphFragmentContentModel
    {
        
    }
    public class CollisionCollection : SceneGraphFragmentContentModel
    {
        
    }
    public class CollisionSpace : SceneGraphFragmentContentModel
    {
        
    }
    public class Contact : SceneGraphFragmentContentModel
    {
        
    }
    public class DoubleAxisHingeJoint : SceneGraphFragmentContentModel
    {
        
    }
    public class MotorJoint : SceneGraphFragmentContentModel
    {
        
    }
    public class RigidBody : SceneGraphFragmentContentModel
    {
        
    }
    public class SingleAxisHingeJoint : SceneGraphFragmentContentModel
    {
        
    }
    public class SliderJoint : SceneGraphFragmentContentModel
    {
        
    }
    public class UniversalJoint : SceneGraphFragmentContentModel
    {
        
    }
}   
