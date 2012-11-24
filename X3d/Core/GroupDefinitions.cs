namespace X3d.Core
{
    /* Extra node groups grouping the virtual node groups below */

    public interface SceneChildContentModel { }

    /* Virtual node groups specified in the X3D specification */

    public interface AppearanceChildContentModel : SceneGraphFragmentContentModel { }
    public interface AppearanceChildContentModelNoProtoInstance { }
    public interface ChildContentModel : GroupingNodeChildContentModel, SceneGraphFragmentContentModel { }
    public interface ChildContentModelCore : SceneChildContentModel, SceneGraphFragmentContentModel { }
    public interface ChildContentModelInterchange : ChildContentModel { }
    public interface ChildContentModelInteractive : ChildContentModel { }
    public interface ChildContentModelImmersive : ChildContentModel { }
    public interface ChildContentModelFull : ChildContentModel { }
    public interface ChildContentModelDIS : ChildContentModel { }
    public interface ChildContentModelGeoSpatial : ChildContentModel { }
    public interface ChildContentModelHumanoidAnimation : ChildContentModel { }
    public interface ChildContentModelNurbs : ChildContentModel { }
    public interface ChildContentModelProtoInstance : ChildContentModel { }
    public interface ChildContentModelSceneGraphStructure : GroupingNodeChildContentModel { }
    public interface ColorCoordinateContentModel { }
    public interface ColorNormalTexCoordContentModel { }
    public interface ComposedGeometryContentModel { }
    public interface ColorCoordinateNormalTexCoordContentModel { }
    public interface GeometryContentModel : SceneGraphFragmentContentModel { }
    public interface GeometryContentModelInterchange { }
    public interface GeometryContentModelInteractive { }
    public interface GeometryContentModelImmersive { }
    public interface GeometryContentModel2D { }
    public interface GeometryContentModelCAD { }
    public interface GeometryContentModel2DImmersive { }
    public interface GeometryContentModelGeoSpatial { }
    public interface GeometryContentModelNurbs { }
    public interface GroupingNodeChildContentModel : SceneChildContentModel { }
    public interface LoadSensorChildContentModel { }
    public interface SceneGraphFragmentContentModel { }
    public interface SceneGraphFragmentWithPrototypeDeclarationsContentModel { }
    public interface ShapeChildContentModel { }
    public interface SoundChildContentModel { }
    public interface TextChildContentModel { }
    public interface TextureBackgroundChildContentModel { }
    public interface LayoutGroupContentModel { }
    public interface RigidJointNodeContentModel { }
    public interface RigidBodyContentModel { }
    public interface RigidBodyCollectionContentModel { }
}                    