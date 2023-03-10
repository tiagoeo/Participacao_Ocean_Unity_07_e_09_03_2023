using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregaNovaFase : MonoBehaviour
{
    public string nomeNovaFase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CarregarNovaFase()
    {
        if (nomeNovaFase != null){
            SceneManager.LoadScene(nomeNovaFase);    
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.name == "Portal")
        {
            CarregarNovaFase();
        }
    }

}
