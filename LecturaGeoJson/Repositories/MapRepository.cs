using LecturaGeoJson.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static LecturaGeoJson.Models.Map;

namespace LecturaGeoJson.Repositories
{
   
    public class MapRepository
    {
        PathService pathService;
        private String path;
        public MapRepository(PathService pathService)
        {
            this.pathService = pathService;
             this.path = this.pathService.MapPath("map.geojson", Folder.Documents);
        }

        public Root GetGeoJson()
        {
            Root map;
            using (StreamReader reader = File.OpenText(this.path))
            {
                var json = reader.ReadToEnd();
                map = JsonConvert.DeserializeObject<Root>(json);
            }

            return map;
        }
    }
}
