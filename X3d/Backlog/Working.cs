namespace X3d.Backlog
{
    using X3d.Core;

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

    public class Background : ChildContentModelInterchange { }
    public class ColorInterpolator : ChildContentModelInterchange { }
    public class CoordinateInterpolator : ChildContentModelInterchange { }
    public class DirectionalLight : ChildContentModelInterchange { }
    public class Group : ChildContentModelInterchange { }
    public class NavigationInfo : ChildContentModelInterchange { }
    public class NormalInterpolator : ChildContentModelInterchange { }
    public class OrientationInterpolator : ChildContentModelInterchange { }
    public class PositionInterpolator : ChildContentModelInterchange { }
    public class ScalarInterpolator : ChildContentModelInterchange { }
    public class Shape : ChildContentModelInterchange { }
    public class TimeSensor : ChildContentModelInterchange { }
    public class Transform : ChildContentModelInterchange { }
    public class Viewpoint : ChildContentModelInterchange { }
    public class WorldInfo : ChildContentModelInterchange { }

    public class Anchor : ChildContentModelInteractive { }
    public class BooleanFilter : ChildContentModelInteractive { }
    public class BooleanSequencer : ChildContentModelInteractive { }
    public class BooleanToggle : ChildContentModelInteractive { }
    public class BooleanTrigger : ChildContentModelInteractive { }
    public class CylinderSensor : ChildContentModelInteractive { }
    public class Inline : ChildContentModelInteractive { }
    public class IntegerSequencer : ChildContentModelInteractive { }
    public class IntegerTrigger : ChildContentModelInteractive { }
    public class KeySensor : ChildContentModelInteractive { }
    public class PlaneSensor : ChildContentModelInteractive { }
    public class PointLight : ChildContentModelInteractive { }
    public class ProximitySensor : ChildContentModelInteractive { }
    public class SphereSensor : ChildContentModelInteractive { }
    public class SpotLight : ChildContentModelInteractive { }
    public class StringSensor : ChildContentModelInteractive { }
    public class Switch : ChildContentModelInteractive { }
    public class TimeTrigger : ChildContentModelInteractive { }
    public class TouchSensor : ChildContentModelInteractive { }

    public class AudioClip : ChildContentModelImmersive { }
    public class Billboard : ChildContentModelImmersive { }
    public class Collision : ChildContentModelImmersive { }
    public class Fog : ChildContentModelImmersive { }
    public class LoadSensor : ChildContentModelImmersive { }
    public class LocalFog : ChildContentModelImmersive { }
    public class LOD : ChildContentModelImmersive { }
    public class Script : ChildContentModelImmersive { }
    public class Sound : ChildContentModelImmersive { }
    public class VisibilitySensor : ChildContentModelImmersive { }

    public class CoordinateInterpolator2D : ChildContentModelFull { }
    public class PositionInterpolator2D : ChildContentModelFull { }
    public class ClipPlane : ChildContentModelFull { }
    public class EaseInEaseOut : ChildContentModelFull { }
    public class LinePickSensor : ChildContentModelFull { }
    public class PickableGroup : ChildContentModelFull { }
    public class PointPickSensor : ChildContentModelFull { }
    public class PrimitivePickSensor : ChildContentModelFull { }
    public class VolumePickSensor : ChildContentModelFull { }
    public class SplinePositionInterpolator : ChildContentModelFull { }
    public class SplinePositionInterpolator2D : ChildContentModelFull { }
    public class SplineScalarInterpolator : ChildContentModelFull { }
    public class SquadOrientationInterpolator : ChildContentModelFull { }
    public class StaticGroup : ChildContentModelFull { }
    public class CADAssembly : ChildContentModelFull { }
    public class CADLayer : ChildContentModelFull { }
    public class OrthoViewpoint : ChildContentModelFull { }
    public class ViewpointGroup : ChildContentModelFull { }
    public class ColorDamper : ChildContentModelFull { }
    public class CoordinateDamper : ChildContentModelFull { }
    public class OrientationChaser : ChildContentModelFull { }
    public class OrientationDamper : ChildContentModelFull { }
    public class PositionChaser : ChildContentModelFull { }
    public class PositionChaser2D : ChildContentModelFull { }
    public class PositionDamper : ChildContentModelFull { }
    public class PositionDamper2D : ChildContentModelFull { }
    public class ScalarChaser : ChildContentModelFull { }
    public class TexCoordDamper2D : ChildContentModelFull { }
    public class TextureBackground : ChildContentModelFull { }
    public class CollidableShape : ChildContentModelFull { }
    public class CollisionSensor : ChildContentModelFull { }
    public class RigidBodyCollection : ChildContentModelFull { }
    public class LayerSet : ChildContentModelFull { }
    public class ParticleSystem : ChildContentModelFull { }
    public class TransformSensor : ChildContentModelFull { }

    public class EspduTransform : ChildContentModelDIS { }
    public class ReceiverPdu : ChildContentModelDIS { }
    public class SignalPdu : ChildContentModelDIS { }
    public class TransmitterPdu : ChildContentModelDIS { }
    public class DISEntityManager : ChildContentModelDIS { }

    public class GeoLocation : ChildContentModelGeoSpatial { }
    public class GeoLOD : ChildContentModelGeoSpatial { }
    public class GeoMetadata : ChildContentModelGeoSpatial { }
    public class GeoOrigin : ChildContentModelGeoSpatial { }
    public class GeoPositionInterpolator : ChildContentModelGeoSpatial { }
    public class GeoProximitySensor : ChildContentModelGeoSpatial { }
    public class GeoTouchSensor : ChildContentModelGeoSpatial { }
    public class GeoViewpoint : ChildContentModelGeoSpatial { }
    public class GeoTransform : ChildContentModelGeoSpatial { }

    public class HAnimHumanoid : ChildContentModelHumanoidAnimation { }
    public class HAnimJoint : ChildContentModelHumanoidAnimation { }
    public class HAnimSegment : ChildContentModelHumanoidAnimation { }
    public class HAnimSite : ChildContentModelHumanoidAnimation { }

    public class NurbsOrientationInterpolator : ChildContentModelNurbs { }
    public class NurbsPositionInterpolator : ChildContentModelNurbs { }
    public class NurbsSurfaceInterpolator : ChildContentModelNurbs { }
    public class NurbsSet : ChildContentModelNurbs { }

    public class ProtoInstance : ChildContentModelProtoInstance, AppearanceChildContentModel { }

    public class FillProperties : AppearanceChildContentModelNoProtoInstance {}
    public class LineProperties : AppearanceChildContentModelNoProtoInstance {}
    public class Material : AppearanceChildContentModelNoProtoInstance {}
    public class TwoSidedMaterial : AppearanceChildContentModelNoProtoInstance {}
    public class ComposedShader : AppearanceChildContentModelNoProtoInstance {}
    public class PackagedShader : AppearanceChildContentModelNoProtoInstance {}
    public class ProgramShader : AppearanceChildContentModelNoProtoInstance {}
    public class ComposedCubeMapTexture : AppearanceChildContentModelNoProtoInstance {}
    public class ComposedTexture3D : AppearanceChildContentModelNoProtoInstance {}
    public class ImageTexture : AppearanceChildContentModelNoProtoInstance {}
    public class ImageTexture3D : AppearanceChildContentModelNoProtoInstance {}
    public class MovieTexture : AppearanceChildContentModelNoProtoInstance {}
    public class MultiTexture : AppearanceChildContentModelNoProtoInstance {}
    public class PixelTexture : AppearanceChildContentModelNoProtoInstance {}
    public class PixelTexture3D : AppearanceChildContentModelNoProtoInstance {}
    public class GeneratedCubeMapTexture : AppearanceChildContentModelNoProtoInstance {}
    public class ImageCubeMapTexture : AppearanceChildContentModelNoProtoInstance {}
    public class MultiTextureTransform : AppearanceChildContentModelNoProtoInstance {}
    public class TextureTransform : AppearanceChildContentModelNoProtoInstance {}
    public class TextureTransform3D : AppearanceChildContentModelNoProtoInstance {}
    public class TextureTransformMatrix3D : AppearanceChildContentModelNoProtoInstance {}
}
