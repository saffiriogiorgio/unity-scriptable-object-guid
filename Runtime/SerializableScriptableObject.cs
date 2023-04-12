using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UnityExtendedScriptable
{
    public class SerializableScriptableObject : ScriptableObject
    {
        [SerializeField]
        private UnityExtendedScriptable.Guid m_guid;
        public Guid Guid => m_guid;

#if UNITY_EDITOR
        void OnValidate()
        {
            if(m_guid.IsEmpty())
            {
                ReloadGUID();
            }
        }

        private void ReloadGUID()
        {
            var path = AssetDatabase.GetAssetPath(this);
            m_guid = System.Guid.Parse(AssetDatabase.AssetPathToGUID(path));
        }
#endif
    }
}