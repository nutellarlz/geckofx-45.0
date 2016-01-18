namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCSessionDescription : WebIDLBase
    {
        
        public RTCSessionDescription(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public RTCSdpType Type
        {
            get
            {
                return this.GetProperty<RTCSdpType>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public nsAString Sdp
        {
            get
            {
                return this.GetProperty<nsAString>("sdp");
            }
            set
            {
                this.SetProperty("sdp", value);
            }
        }
    }
}
