using System;

public class MessageEvent
{
	public delegate void MessageDelegate(Message msg);
	private event MessageDelegate messageEvent;

	public void Dispatch(Message msg)
	{
	    if (messageEvent != null)
	    {
	        messageEvent(msg);
	    }
	}

	public static MessageEvent operator +(MessageEvent element, MessageDelegate msgDelegate)
	{
	    element.messageEvent += msgDelegate;
	    return element;
	}

	public static MessageEvent operator -(MessageEvent element, MessageDelegate msgDelegate)
	{
	    element.messageEvent -= msgDelegate;
	    return element;
	}
}
