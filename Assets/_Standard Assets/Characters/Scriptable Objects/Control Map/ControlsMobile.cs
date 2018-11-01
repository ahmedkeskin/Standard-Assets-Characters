// GENERATED AUTOMATICALLY FROM 'Assets/_Standard Assets/Characters/Scriptable Objects/Control Map/ControlsMobile.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class ControlsMobile : InputActionAssetReference
{
    public ControlsMobile()
    {
    }
    public ControlsMobile(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // Movement
        m_Movement = asset.GetActionMap("Movement");
        m_Movement_look = m_Movement.GetAction("look");
        m_Movement_move = m_Movement.GetAction("move");
        m_Movement_sprint = m_Movement.GetAction("sprint");
        m_Movement_jump = m_Movement.GetAction("jump");
        m_Movement_crouch = m_Movement.GetAction("crouch");
        m_Movement_recentre = m_Movement.GetAction("recentre");
        m_Movement_strafe = m_Movement.GetAction("strafe");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Movement = null;
        m_Movement_look = null;
        m_Movement_move = null;
        m_Movement_sprint = null;
        m_Movement_jump = null;
        m_Movement_crouch = null;
        m_Movement_recentre = null;
        m_Movement_strafe = null;
        m_Initialized = false;
    }
    public void SwitchAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public void DuplicateAndSwitchAsset()
    {
        SwitchAsset(ScriptableObject.Instantiate(asset));
    }
    // Movement
    private InputActionMap m_Movement;
    private InputAction m_Movement_look;
    private InputAction m_Movement_move;
    private InputAction m_Movement_sprint;
    private InputAction m_Movement_jump;
    private InputAction m_Movement_crouch;
    private InputAction m_Movement_recentre;
    private InputAction m_Movement_strafe;
    public struct MovementActions
    {
        private ControlsMobile m_Wrapper;
        public MovementActions(ControlsMobile wrapper) { m_Wrapper = wrapper; }
        public InputAction @look { get { return m_Wrapper.m_Movement_look; } }
        public InputAction @move { get { return m_Wrapper.m_Movement_move; } }
        public InputAction @sprint { get { return m_Wrapper.m_Movement_sprint; } }
        public InputAction @jump { get { return m_Wrapper.m_Movement_jump; } }
        public InputAction @crouch { get { return m_Wrapper.m_Movement_crouch; } }
        public InputAction @recentre { get { return m_Wrapper.m_Movement_recentre; } }
        public InputAction @strafe { get { return m_Wrapper.m_Movement_strafe; } }
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
    }
    public MovementActions @Movement
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new MovementActions(this);
        }
    }
}