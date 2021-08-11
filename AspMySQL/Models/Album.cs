using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMySQL.Models
{
    public class Album
    {
        private MusicContext context;
        public int Id { get; set; }
        public string name { get; set; }
        public string artist { get; set; }
    }
}
