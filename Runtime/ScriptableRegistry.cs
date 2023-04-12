using System.Collections.Generic;
using UnityEngine;

namespace UnityExtendedScriptable
{
    public abstract class ScriptableRegistry<T> : ScriptableObject where T : SerializableScriptableObject
    {
        [SerializeField] protected List<T> m_scriptableCollection = new List<T>();

        public T FindByGuid(System.Guid guid)
        {
            foreach (var desc in m_scriptableCollection)
            {
                if (desc.Guid == guid)
                {
                    return desc;
                }
            }

            return null;
        }
    }
}
