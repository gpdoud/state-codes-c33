using System;
using System.Collections.Generic;

namespace state_codes
{
	class Program
	{
		static void Main(string[] args)
		{
			var states = new List<State>()
			{
				new State("OH", "Ohio"),
				new State("KY", "Kentucky"),
				new State("IN", "Indiana")
			};

			//var stateoh = new State("OH", "Ohio");
			//states.Add(stateoh);

			//var stateky = new State("KY", "Kentucky");
			//states.Add(stateky);

			//states.Add( new State("IN", "Indiana") );

			foreach(var state in states)
			{
				Console.WriteLine($"The code {state.Code} is name {state.Name}");
			}







			//var statecodes = new Dictionary<string, string>()
			//{
			//	["OH"] = "Ohio", ["IN"] = "Indiana", ["KY"] = "Kentucky"
			//};
			////statecodes.Add("OH", "Ohio");
			////statecodes.Add("IN", "Indiana");
			////statecodes.Add("KY", "Kentucky");

			//var ohio = statecodes["OH"];
			//Console.WriteLine(ohio);
		}
	}
}
