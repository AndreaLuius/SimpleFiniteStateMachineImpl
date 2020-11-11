using Scenes.states;
using UnityEngine;
using UnityEngine.Rendering;

namespace Scenes
{
    public class PlayerFsm : Fsm
    {
        public PlayerFsm()
        {
        }

        public void add(PlayerFsmState state)
        {
            states.Add((int)state.ID,state);
        }
        
        public PlayerFsmState getState(PlayerFsmStateType key)
        {
            return (PlayerFsmState) getState((int) key);
        }

        public void setCurrentState(PlayerFsmStateType stateKey)
        {
            State state = states[(int) stateKey];
            if (state != null)
            {
                setCurrentState(state);
            }
        }
    }
}