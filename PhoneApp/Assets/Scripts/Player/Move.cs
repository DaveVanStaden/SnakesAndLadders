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
    private Vector3 _mouseWorldPositionCurrent;
    [SerializeField] private GameObject _gameControllerObject;
    private Turn _gameControllerTurn;
    private bool _isDraggingObject;
    void Start()
    {
        _gameControllerTurn = _gameControllerObject.GetComponent<Turn>();
    }
    void Update()
    {  
        RaycastHit hit;
        Ray castPoint = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
        {
            _mouseWorldPositionCurrent = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.tag == "enemy" && hit.collider.GetComponent<PlayerInitialize>().player == _gameControllerTurn.GetTurn())
                {
                    _isDraggingObject = true;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            _isDraggingObject = false;
        }
        if (_isDraggingObject) {
            switch (_gameControllerTurn.GetTurn())
            {
                case 1:
                    player1.transform.position = new Vector3(_mouseWorldPositionCurrent.x, 18f, _mouseWorldPositionCurrent.z);
                    break;
                case 2:
                    player2.transform.position = new Vector3(_mouseWorldPositionCurrent.x, 18f, _mouseWorldPositionCurrent.z);
                    break;
                case 3:
                    player3.transform.position = new Vector3(_mouseWorldPositionCurrent.x, 18f, _mouseWorldPositionCurrent.z);
                    break;
                case 4:
                    player4.transform.position = new Vector3(_mouseWorldPositionCurrent.x, 18f, _mouseWorldPositionCurrent.z);
                    break;
            }
        }
    }
}