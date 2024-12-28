using System.Collections.Generic;
using UnityEngine;

namespace Scriptable_Objects_Scripts
{
    [CreateAssetMenu(fileName = "CharacterType", menuName = "Scriptable Objects/Character Type")]
    public class CharacterType : ScriptableObject
    {
        public string className;
        public List<string> friendlyClasses = new List<string>();
        public List<string> enemyClasses = new List<string>();
    }
}