using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLocomotion : GazeInteractable
{
   public Vector3 playerHeightOffset = new Vector3(0, 1.6f, 0);

    // Start is called before the first frame update
   public override void OnPointerEnter()
   {
       base.OnPointerEnter();
   }

   public override void OnPointerExit()
   {
       base.OnPointerExit();
   }

   public override void OnPointerClick()
   {
       base.OnPointerClick();
       
       //Teletrasportar al jugador a las coordenadas de este objeto
       Transform player = GameObject.FindGameObjectWithTag("Player").transform;//FindGameObjectsWithTag
       //transform es el componente que controla las cooredendas, rotacion, etc.

       player.position = transform.position + playerHeightOffset;


   }
}
