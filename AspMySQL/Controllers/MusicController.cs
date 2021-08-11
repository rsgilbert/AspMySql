using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMySQL.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspMySQL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {
        private MusicContext _musicContext { get; set; }

        public MusicController(MusicContext musicContext)
        {
            _musicContext = musicContext;
        }
        /**
         * Get all albums
         */
        public ActionResult<List<Album>> GetAll()
        {
            List<Album> albums = _musicContext.GetAllAlbums();
            return albums;
        }
    }
}
