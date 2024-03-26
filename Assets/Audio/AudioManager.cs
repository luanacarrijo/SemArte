using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

namespace Template.Game
{
    public class AudioManager : Manager<AudioManager>
    {
        [BankRef]
        public List<string> banks;
        
        protected override void OnCreateManager()
        {
        }

        protected override void OnDestroyManager()
        {
        }
    }
}
