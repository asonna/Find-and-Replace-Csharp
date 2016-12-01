using Nancy;
using System.Collections.Generic;
using FindReplaceGame.Objects;

namespace FindReplaceGame
{
	public class HomeModule: NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
		}
	}
}
