using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Homepage() { return View(); }

    [Route("/halloween-form")]
    public ActionResult HalloweenForm() { return View(); }

    [Route("/halloween-mad-lib")]
    public ActionResult HalloweenStory(string verbOne, string adjectiveOne, string pluralNounOne, string colorOne, string noun, string verbTwo, string adjectiveTwo, string food)
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

    [Route("/princess-form")]
    public ActionResult PrincessForm() { return View(); }

    [Route("/princess-mad-lib")]
    public ActionResult PrincessStory(string adjectiveOne, string name, string number, string relative, string firstLocation, string secondLocation)
    {
      StoryVariables myStoryVariables = new StoryVariables();
      myStoryVariables.AdjectiveOne = adjectiveOne;
      myStoryVariables.Name = name;
      myStoryVariables.Number = number;
      myStoryVariables.Relative = relative;
      myStoryVariables.FirstLocation = firstLocation;
      myStoryVariables.SecondLocation = secondLocation;
      return View(myStoryVariables);
    }
  }
}