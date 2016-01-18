namespace Gecko.WebIDL
{
    using System;
    
    
    public class CustomEvent : WebIDLBase
    {
        
        public CustomEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Detail
        {
            get
            {
                return this.GetProperty<object>("detail");
            }
        }
        
        public void InitCustomEvent(nsAString type, bool canBubble, bool cancelable, object detail)
        {
            this.CallVoidMethod("initCustomEvent", type, canBubble, cancelable, detail);
        }
    }
}
