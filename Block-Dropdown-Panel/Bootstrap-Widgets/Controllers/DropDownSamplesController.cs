using System.Web.Mvc;
using SamplesData;

namespace Bootstrap_Widgets.Controllers
{
  public class DropDownSamplesController : Controller
  {
    public ActionResult DropDown01()
    {
      MusicGenre entity = new MusicGenre();

      return View(entity);
    }

    public ActionResult DropDown02()
    {
      MusicGenre entity = new MusicGenre();

      //entity.Genre = "Rock";

      return View(entity);
    }

    [HttpPost]
    public ActionResult DropDown02(MusicGenre entity)
    {      

      return View(entity);
    }

    public ActionResult DropDown03()
    {
      MusicGenre entity = new MusicGenre();
      return View(entity);
    }

    [HttpPost]
    public ActionResult DropDown03(MusicGenre entity)
    {
      return View(entity);
    }

    public ActionResult DropDown04()
    {
      MusicGenre entity = new MusicGenre();
      return View(entity);
    }

    [HttpPost]
    public ActionResult DropDown04(MusicGenre entity)
    {      
      return View(entity);
    }

    public ActionResult DropDown05()
    {
      MusicGenreViewModel vm = new MusicGenreViewModel();
      return View(vm);
    }

    [HttpPost]
    public ActionResult DropDown05(MusicGenreViewModel vm)
    {
      return View(vm);
    }
  }
}