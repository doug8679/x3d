namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// This abstract node type is the base type for all nodes in the X3D system.
    /// </summary>
    public abstract class X3DNode
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
