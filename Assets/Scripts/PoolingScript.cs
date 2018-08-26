using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PoolingScript : MonoBehaviour
{
    // just deactivate bullets 
    void OnEnable()
    {
        Invoke("Destroy", 2f);
    }

    void Destroy()
    {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke();
    }


}
