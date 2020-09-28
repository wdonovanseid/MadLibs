using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {


    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/mad-lib")]
    public ActionResult Story(string verbOne, string adjectiveOne, string pluralNounOne, string colorOne, string noun, string verbTwo, string adjectiveTwo, string food)
    {
      StoryVariables myStoryVariables = new StoryVariables();
      myStoryVariables.VerbOne = verbOne;
      myStoryVariables.AdjectiveOne = adjectiveOne;
      myStoryVariables.PluralNoun = pluralNounOne;
      myStoryVariables.Color = colorOne;
      myStoryVariables.Noun = noun;
      myStoryVariables.VerbTwo = verbTwo;
      myStoryVariables.AdjectiveTwo = adjectiveTwo;
      myStoryVariables.Food = food;
      return View(myStoryVariables);
    }

  }
}