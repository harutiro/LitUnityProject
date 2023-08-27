using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    RendererLists rendererLists;

    // Start is called before the first frame update
    void Start()
    {
        rendererLists = this.gameObject.GetComponent<RendererLists>();
        rendererLists.colorCubeRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rendererLists.cubyRenderer.material.color = rendererLists.colorCubeRenderer.material.color;
        rendererLists.colorCubeRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
