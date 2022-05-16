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

        [HttpGet]
        public IActionResult GetGamesById()
        {
            var videoGames = _context.VideoGames;

            return Ok(videoGames);
        }

        [HttpGet ("{id}")]

        public IActionResult GetGamesById(int id)
        {
            var videoGames = _context.VideoGames.Where(vg => vg.Id == id);          
            return Ok(videoGames);
        }
            
    }
}
