namespace X3d.Core
{
    using System.Xml;
    using System.Xml.Schema;

    /// <summary>
    /// X3DField is the abstract field type from which all single values field
    /// types are derived.
    /// </summary>
    public abstract class X3DField
    {
        #region String Compatibility

        public abstract void FromString(string str);

        #endregion String Compatibility
    }
}