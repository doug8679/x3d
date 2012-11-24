namespace X3d.Core
{
    using System;

    /// <summary>
    /// X3DBindableNode is the abstract base type for all bindable children 
    /// nodes, including Background, TextureBackground, Fog, NavigationInfo 
    /// and Viewpoint.
    /// </summary>
    public abstract class X3DBindableNode : X3DChildNode
    {
        protected X3DBindableNode()
        {
            this.IsBound = false;
            this.BindTime = -1;
        }

        public void SetBind(SFBool obj)
        {
            if (obj == true)
            {
                this.IsBound = true;
                this.BindTime = DateTime.Now;
            }
            else
            {
                this.IsBound = false;
                this.BindTime = -1;
            }
        }

        public SFTime BindTime { get; protected set; }

        public SFBool IsBound { get; protected set; }
    }
}
