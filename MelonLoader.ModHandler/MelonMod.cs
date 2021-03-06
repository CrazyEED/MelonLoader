﻿namespace MelonLoader
{
    public abstract class MelonMod
    {
        /// <summary>
        /// Gets if the Mod is Universal or not.
        /// </summary>
        public bool IsUniversal { get; internal set; }

        /// <summary>
        /// Gets the Info Attribute of the Mod.
        /// </summary>
        public MelonModInfoAttribute InfoAttribute { get; internal set; }

        /// <summary>
        /// Gets the Game Attributes of the Mod.
        /// </summary>
        public MelonModGameAttribute[] GameAttributes { get; internal set; }

        public virtual void OnApplicationStart() {}
        public virtual void OnLevelWasLoaded(int level) {}
        public virtual void OnLevelWasInitialized(int level) {}
        public virtual void OnUpdate() {}
        public virtual void OnFixedUpdate() {}
        public virtual void OnLateUpdate() {}
        public virtual void OnGUI() {}
        public virtual void OnApplicationQuit() {}
        public virtual void OnModSettingsApplied() {}
        public virtual void VRChat_OnUiManagerInit() {}
    }
}