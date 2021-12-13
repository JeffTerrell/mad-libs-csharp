using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Letter() 
    {
      MadLibsVariable myLetterVariable = new MadLibsVariable();
      myLetterVariable.Recipient = "Jeff";
      myLetterVariable.Sender = "Terrell";
      return View(myLetterVariable); 
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/MadLibs")]
    public ActionResult MadLibs(string recipient, string sender) 
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Recipient = recipient;
      myMadLibsVariable.Sender = sender;
      return View(myMadLibsVariable); 
    }
  }
}

