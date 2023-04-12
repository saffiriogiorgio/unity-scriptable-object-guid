using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtendedScriptable.Test
{
    public class Card : SerializableScriptableObject
    {
        [SerializeField]
        private string m_name;
        [SerializeField, Multiline]
        private string m_description;

        [Space]
        [SerializeField]
        private int m_attack;
        [SerializeField]
        private int m_defense;
        [SerializeField]
        private int m_level;

        public string GetName => m_name;
        public string GetDescription => m_description;
        public int GetAttack => m_attack;
        public int GetDefense => m_defense;
        public int GetLevel => m_level;
    }
}
