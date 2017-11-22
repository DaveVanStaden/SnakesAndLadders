using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScreen : MonoBehaviour {
    private bool _isDragging = false;
    private Vector2 _mousePosition;
    private Vector3 _mouseWorldPosition;
    private Vector3 _mouseWorldPositionCurrent;

    [SerializeField] private float _screenClamp;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !_isDragging)
        {
            _isDragging = true;
           /* _mousePosition.x = Input.mousePosition.x;
            _mousePosition.y = Camera.main.pixelHeight / 2 - Input.mousePosition.y;
            _mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(_mousePosition.x, 0f, _mousePosition.y));
            */
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                _mouseWorldPosition = hit.point;
            }
        }
        else if (Input.GetMouseButtonUp(0) && _isDragging)
        {
            _isDragging = false;
        }

        if (_isDragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag != "enemy")
                {
                    _mouseWorldPositionCurrent = hit.point;
                }
                else
                {
                    _isDragging = false;
                }
            }

            if (_isDragging)
            {
                float xPos = Mathf.Clamp(_mouseWorldPosition.x - (_mouseWorldPositionCurrent.x - Camera.main.transform.position.x), -_screenClamp, _screenClamp);
                float yPos = Camera.main.transform.position.y;
                float zPos = Mathf.Clamp(_mouseWorldPosition.z - (_mouseWorldPositionCurrent.z - Camera.main.transform.position.z), -_screenClamp, _screenClamp);
                Camera.main.transform.position = new Vector3(xPos, yPos, zPos);
            }
        }
    }
}
