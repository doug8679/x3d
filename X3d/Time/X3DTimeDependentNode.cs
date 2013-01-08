namespace X3d.Time
{
    using X3d.Core;

    /// <summary>
    /// This abstract node type is the base node type from which 
    /// all time-dependent nodes are derived.
    /// </summary>
    public abstract class X3DTimeDependentNode : X3DChildNode
    {
        protected X3DTimeDependentNode()
        {
            this.Loop       = false;
            this.PauseTime  = 0;
            this.ResumeTime = 0;
            this.StartTime  = 0;
            this.StopTime   = 0;
        }

        public SFBool Loop { get; set; }
        public SFTime PauseTime { get; set; }
        public SFTime ResumeTime { get; set; }
        public SFTime StartTime { get; set; }
        public SFTime StopTime { get; set; }

        public SFTime ElapsedTime 
        {
            get 
            { 
                // TODO: Implement this
            }
        }

        public SFBool IsActive
        {
            get
            {
                // TODO: Implement this
            }
        }

        public SFBool IsPaused
        {
            get
            {
                // TODO: Implement this
            }
        }
    }
}
