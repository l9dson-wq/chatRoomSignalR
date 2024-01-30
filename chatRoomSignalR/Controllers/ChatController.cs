using Microsoft.AspNetCore.Mvc;

namespace chatRoomSignalR.Controllers
{
  public class ChatController : Controller
  {

    public static Dictionary<int, string> Rooms =
      new()
      {
        { 1, "Cervezas" },
        { 2, "Programacion" },
        { 3, "Moda" }
      };

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Room(int room)
    {
      return View("Room", room);
    }
  }
}
