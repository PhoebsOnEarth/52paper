using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SectionD.Models;
using SectionD.Data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SectionD.Controllers;
[Route("api/exam")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DbSongs _context;
    public HomeController(ILogger<HomeController> logger,DbSongs context)
    {
        _logger = logger;
        _context = context;
    }
    [Route("/exam-index")]
    public async Task<IActionResult> Index(int mins,int secs)
    {
        var songs = await _context.Songs.Include(s => s.Genres).ToArrayAsync();
        return View(songs);
    }
    [Route("search")]
    public IActionResult Search(int mins,int secs)
    {

        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

