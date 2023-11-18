// Created by: Ryan King
// Edited by: Bill D.

using UnityEngine;

namespace Devhouse.Tools.Utilities
{
    public class GameObjectUtility : MonoBehaviour
    {
        public void ToggleThisActive()
        {
            gameObject.ToggleActive();
        }

        public void ToggleOtherObjectActive(GameObject other)
        {
            other.ToggleActive();
        }
    }
}
