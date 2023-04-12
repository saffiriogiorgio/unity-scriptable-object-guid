using Codice.CM.Interfaces;
using System;
using UnityEngine;

namespace UnityExtendedScriptable
{
    [Serializable]
    public struct Guid : IEquatable<Guid>
    {
        private System.Guid m_guid;
        public readonly System.Guid GetGUID => m_guid;

#if UNITY_EDITOR
        [SerializeField]
        private string m_guidSerialized;
#endif
        public Guid(System.Guid aNewGuid)
        {
            m_guid = aNewGuid;
#if UNITY_EDITOR
            m_guidSerialized = m_guid.ToString("N");
#endif
        }

        public Guid(string aNewGuid) 
        { 
            System.Guid.TryParse(aNewGuid, out m_guid);
#if UNITY_EDITOR
            m_guidSerialized = m_guid.ToString("N");
#endif
        }

        public static implicit operator Guid(string value) => new Guid(value);
        public static implicit operator Guid(System.Guid value) => new Guid(value);
        public static implicit operator System.Guid(Guid other) => new System.Guid(other.ToString());

        public static bool operator ==(Guid lhs, Guid rhs) => lhs.Equals(rhs);
        public static bool operator ==(Guid lhs, System.Guid rhs) => lhs.Equals(rhs);
        public static bool operator !=(Guid obj1, Guid obj2) => !(obj1 == obj2);
        public static bool operator !=(Guid obj1, System.Guid obj2) => !(obj1 == obj2);


        public bool Equals(Guid other)
        {
            return m_guid.Equals(other.GetGUID);
        }
        public bool Equals(System.Guid other)
        {
            return m_guid.Equals(other);
        }

        public override bool Equals(object obj)
        {
            return obj is Guid other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return m_guid.GetHashCode();
        }

        public override string ToString()
        {
            return m_guid.ToString();
        }

        public string ToString(string param)
        {
            return m_guid.ToString(param);
        }

        public bool IsEmpty()
        {
            return m_guid == System.Guid.Empty;
        }

    }
}
