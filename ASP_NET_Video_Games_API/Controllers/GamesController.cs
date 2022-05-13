﻿using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{pubName}")]
        public IActionResult GetPublishers()
        {
            //var videoGamePublishers = _context.VideoGames.Select(vg => vg.Publisher).Distinct();

            //return Ok(videoGamePublishers);
            Console.WriteLine("Endpoint hit");
            var games = _context.VideoGames;
            return Ok(games);
        }

        [HttpGet]

        public IActionResult GetGamesByPublisher(string pubName)
        {
            var videoGames = _context.VideoGames.Where(vg => vg.Publisher == pubName);
            return Ok(videoGames);
        }
            
    }
}
