namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCdmaIccInfo : WebIDLBase
    {
        
        public MozCdmaIccInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Mdn
        {
            get
            {
                return this.GetProperty<nsAString>("mdn");
            }
        }
        
        public int PrlVersion
        {
            get
            {
                return this.GetProperty<int>("prlVersion");
            }
        }
    }
}
