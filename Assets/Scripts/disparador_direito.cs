using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador_direito : MonoBehaviour {

    public GameObject projetil_direito;

	// Update is called once per frame
	void Update () {
        // Disparos dos projeteis
        if (Input.GetKeyDown("x"))
        {
            // Cria uma nova bala na posiçao do canhão esquerdo para que siga a mesma
            Instantiate(projetil_direito, transform.position, Quaternion.identity);
        }
    }
}
