using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("AQUAS Lite/AQUAS Lite Camera")]
[RequireComponent(typeof(Camera))]
public class AquaCam : MonoBehaviour
{
    #if UNITY_EDITOR
        void OnDrawGizmos()
        {
            Set();
        }
#endif
        void Start()
        {
            Set();
        }
        void Set()
        {
            if (GetComponent<Camera>().depthTextureMode == DepthTextureMode.None)
                GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
        }
}
