using Nancy;
using System.Collections.Generic;
using Scrapple.Objects;
using System;

namespace Scrapple
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/"] = _ => {
        ScrappleWord newWord =  new ScrappleWord(Request.Form["word"]);
        return View["/index.cshtml", newWord];
      };

    }
  }
}
