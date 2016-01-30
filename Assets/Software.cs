using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Software
{
	public string Message { get; set; }
	public Objeto Objeto { get; set; }
	
	public string BreakPassword()
	{
		if (Objeto == null)
			return "ERROR:.No 'call' found\n>";
		
		if (!Objeto.HasPassword)
			return "ERROR:.No Password To Crack\n>";
		
		Objeto.HasPassword = false;
		return "Breaking Password...Ok\n>";
	}
	
	public string Read()
	{
		return Message;
	}
}
