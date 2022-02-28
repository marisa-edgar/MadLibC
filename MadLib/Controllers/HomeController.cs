using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/results")]
    public ActionResult Results(string adjective1, string adjective2, string bird, string room, string verb1, string verb2, string relative, string noun1, string noun2, string verbIng, string body, string pluralNoun, string verbIng2, string noun3)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Adjective1 = adjective1;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Bird = bird;
      myMadLibVariable.Room = room;
      myMadLibVariable.Verb1 = verb1;
      myMadLibVariable.Verb2 = verb2;
      myMadLibVariable.Relative = relative;
      myMadLibVariable.Noun1 = noun1;
      myMadLibVariable.Noun2 = noun2;
      myMadLibVariable.VerbIng = verbIng;
      myMadLibVariable.Body = body;
      myMadLibVariable.PluralNoun = pluralNoun;
      myMadLibVariable.VerbIng2 = verbIng2;
      myMadLibVariable.Noun3 = noun3;
    

      return View(myMadLibVariable);
    }
  }
}