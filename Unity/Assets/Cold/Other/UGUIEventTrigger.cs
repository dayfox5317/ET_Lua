using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Battlehub.RTCommon
{
    public delegate void DragDropEventHander(PointerEventData pointerEventData);
    [DefaultExecutionOrder(-50)]
    public class UGUIEventTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,IBeginDragHandler,IDragHandler,IEndDragHandler,IDropHandler,IMoveHandler,
        ICancelHandler,IDeselectHandler,ISelectHandler,IScrollHandler,ISubmitHandler,IPointerClickHandler,IPointerDownHandler,IPointerUpHandler
    {
        public event DragDropEventHander OnPointerEnterEvent;
        public event DragDropEventHander OnPointerExitEvent;
        public event DragDropEventHander OnPointerClickEvent;
        public event DragDropEventHander OnPointerDownEvent;
        public event DragDropEventHander OnPointerUpEvent;
        public event DragDropEventHander OnScrollEvent;
        public event DragDropEventHander OnBeginDragEvent;
        public event DragDropEventHander OnDragEvent;
        public event DragDropEventHander OnEndDragEvent;
        public event DragDropEventHander OnDropEvent;



        public virtual bool IsPointerOver
        {
            get;
            set;
        }
       
        void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
        {
            IsPointerOver = true;
            OnPointerEnterEvent?.Invoke(eventData);
         
        }

        void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
        {
            IsPointerOver = false;
            OnPointerExitEvent?.Invoke(eventData);
        }

        public void OnCancel(BaseEventData eventData)
        {
      //      throw new System.NotImplementedException();
        }

        void IScrollHandler.OnScroll(PointerEventData eventData)
        {
            OnScrollEvent?.Invoke(eventData);
         //   throw new System.NotImplementedException();
        }

        public void OnSelect(BaseEventData eventData)
        {
            //throw new System.NotImplementedException();
        }

        public void OnSubmit(BaseEventData eventData)
        {
            //throw new System.NotImplementedException();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            OnPointerClickEvent?.Invoke(eventData);
        }

        public void OnDeselect(BaseEventData eventData)
        {
        //    throw new System.NotImplementedException();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            OnBeginDragEvent?.Invoke(eventData);
        }

        public void OnDrag(PointerEventData eventData)
        {
            OnDragEvent?.Invoke(eventData);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            OnEndDragEvent?.Invoke(eventData);
        }

        public void OnDrop(PointerEventData eventData)
        {
            OnDropEvent?.Invoke(eventData);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            OnPointerDownEvent?.Invoke(eventData);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            OnPointerUpEvent?.Invoke(eventData);
        }

        public void OnMove(AxisEventData eventData)
        {
          //  throw new System.NotImplementedException();
        }
    }
}

