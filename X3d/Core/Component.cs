namespace X3d.Core
{
    using System;

    public class Component : SceneGraphStructureNodeType
    {
        public Component()
        {
            this.Name = ComponentNames.Core;
            this.Level = null;
        }

        public Component(ComponentNames name, SFInt32 level)
        {
            this.Name = name;
            this.Level = level;
        }

        public ComponentNames Name { get; set; }

        private SFInt32 level;

        public SFInt32 Level
        {
            get
            {
                return this.level;
            }

            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Level can be between 1 and 5. Value = {0}", value));
                }

                this.level = value;
            }
        }
    }
}
