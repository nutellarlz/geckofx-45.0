namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFC : WebIDLBase
    {
        
        public MozNFC(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Enabled
        {
            get
            {
                return this.GetProperty<bool>("enabled");
            }
        }
        
        public void EventListenerWasAdded(nsAString aType)
        {
            this.CallVoidMethod("eventListenerWasAdded", aType);
        }
        
        public void EventListenerWasRemoved(nsAString aType)
        {
            this.CallVoidMethod("eventListenerWasRemoved", aType);
        }
    }
}
