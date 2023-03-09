using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAtivador : MonoBehaviour
{

    public GameObject objetoParaDesativar;

    public GameObject objetoParaAtivar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (objetoParaDesativar != null)
        {
            objetoParaDesativar.SetActive(false);
        }

        if (objetoParaAtivar != null)
        {
            objetoParaAtivar.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (objetoParaDesativar != null)
        {
            objetoParaDesativar.SetActive(true);
        }

        if (objetoParaAtivar != null)
        {
            objetoParaAtivar.SetActive(false);
        }
    }
}
