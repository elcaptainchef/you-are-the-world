using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;



/*the abstract class allows the children to override anything i may need to act differently.
here is some reddit advice who explains it better than the video who didnt explain anything.

thank you GameWorldShaper!

It is not one vs the other, both are needed in development. Abstract classes are for different versions of a core class. Interfaces are for adding an expected functionality to an object.

For example, if you code a bunch of different missiles, that is great to do with an Abstract class. However, abilities for missiles like Homing, or Proximity effects are best made with Interfaces. This way you can turn any type of missile into a homing version by just adding the Homing interface.

Abstract Class = foundation, Interface = modification.
*/
abstract public class Node : MonoBehaviour {

    public Transform cameraPosition; //this will move the camera when the node is clicked into. obvi not set yet. its for the children to determine when we make one
    public List<Node> reachableNodes = new List<Node>(); //iirc this will allow a list WITHIN unity on the object that has it. so you can decide what you want to consider as a "reachable node" and drag and drop them into the list.
    public Collider col;
    

    // Start is called before the first frame update
    void Start() {
        col = GetComponent<Collider>(); //stop forgetting to have the component assigned to the goddamn variable To david from david
    }

  
}
