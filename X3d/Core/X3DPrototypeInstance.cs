namespace X3d.Core
{
    /// <summary>
    /// This abstract node type is the base type for all prototype instances
    /// in the X3D system. Any user-defined nodes declared with PROTO or 
    /// EXTERNPROTO are instantiated using this base type. 
    /// An X3DPrototypeInstance may be place anywhere in the scene graph 
    /// where it is legal to place the first node declared within the 
    /// prototype instance. For example, if the base type of first node is 
    /// X3DAppearanceNode, that prototype may be instantiated anywhere in 
    /// the scene graph that allows for an appearance node.
    /// </summary>
    public abstract class X3DPrototypeInstance : X3DNode
    {
    }
}
