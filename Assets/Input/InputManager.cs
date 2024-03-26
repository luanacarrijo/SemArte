using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

namespace Template.Game.Input
{
    public class InputManager : Manager<InputManager>
    {
        public InputActionAsset actionAsset;

        private InputUser user;
        
        protected override void OnCreateManager()
        {
        }

        protected override void OnDestroyManager()
        {
        }
    }
}
