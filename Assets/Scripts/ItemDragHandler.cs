using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDragHandler : MonoBehaviour,IDragHandler,IEndDragHandler,IPointerEnterHandler,IPointerExitHandler,IBeginDragHandler
{
    UIDragManager _uiManager;
    bool canStop;


    private void Start() {
        _uiManager = GameObject.Find("UIDragManager").GetComponent<UIDragManager>();
    }


    public string colorName;




    public void OnBeginDrag(PointerEventData eventData) {
        _uiManager.isClicked = true;
        _uiManager.clickedObjectParent = transform.parent.gameObject;
        _uiManager.nextObjectParent = transform.parent.gameObject;
        _uiManager.nextObject = transform.gameObject;
        transform.GetComponent<Image>().raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
 

    }

    public void OnEndDrag(PointerEventData eventData) {
        _uiManager.isClicked = false;
        
            transform.SetParent(_uiManager.nextObjectParent.transform);
            
            transform.localPosition = Vector3.zero;

        _uiManager.nextObject.transform.SetParent(_uiManager.clickedObjectParent.transform);
        _uiManager.nextObject.transform.localPosition = Vector3.zero;
        transform.GetComponent<Image>().raycastTarget = true;


    }
    public void OnPointerEnter(PointerEventData eventData) {
        
        if (_uiManager.isClicked) {
            _uiManager.nextObjectParent = transform.parent.gameObject;
            _uiManager.nextObject = transform.gameObject;
            Debug.Log("Test");
        }
    }

    public void OnPointerExit(PointerEventData eventData) {
        if (_uiManager.isClicked) {
            _uiManager.nextObjectParent = _uiManager.clickedObjectParent;

        }

    }

   
}
