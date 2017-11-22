using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public LayerMask hitLayers;
    private Touch touch;
    [SerializeField] private GameObject _gameControllerObject;
    private Turn _gameControllerTurn;
    bool touchBool;
    void Start()
    {
        _gameControllerTurn = _gameControllerObject.GetComponent<Turn>();
    }
    void Update()
    {  
        if (Input.touchCount >= 1)
        {
            touchBool = true;
        }
        else
        {
            touchBool = false;
        }
        //if (touchBool == true)
        //{
            
            RaycastHit hit;
            //touch = Input.GetTouch(0);
            Ray castPoint = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
            {
                if (Input.GetMouseButton(0))
            {
                if (hit.collider.tag == "enemy")
                {
                    Debug.Log(_gameControllerTurn.GetTurn());
                    switch (_gameControllerTurn.GetTurn())
                    {

                        case 1:
                            player1.transform.position = new Vector3(hit.point.x, 0f, hit.point.z);
                            break;
                        case 2:
                            player2.transform.position = new Vector3(hit.point.x, 0f, hit.point.z);
                            break;
                        case 3:
                            player3.transform.position = new Vector3(hit.point.x, 0f, hit.point.z);
                            break;
                        case 4:
                            player4.transform.position = new Vector3(hit.point.x, 0f, hit.point.z);
                            break;
                    }
                }
            }
                
         }
        }
    //}
}