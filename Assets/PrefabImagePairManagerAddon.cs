using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation.Samples;

public class PrefabImagePairManagerAddon : MonoBehaviour
{

    PrefabImagePairManager prefabImagePairManager;

    [Serializable]
    struct NamedPrefab
    {
        // System.Guid isn't serializable, so we store the Guid as a string. At runtime, this is converted back to a System.Guid
        public string imageGuid;
        public GameObject imagePrefab;

        public NamedPrefab(Guid guid, GameObject prefab)
        {
            imageGuid = guid.ToString();
            imagePrefab = prefab;
        }
    }

    [SerializeField]
    //[HideInInspector]
    List<NamedPrefab> m_PrefabsList = new List<NamedPrefab>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
