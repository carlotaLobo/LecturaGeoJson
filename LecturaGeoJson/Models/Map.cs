using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LecturaGeoJson.Models
{
    public class Map
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Geometry
        {
            public string type { get; set; }
            public List<double> coordinates { get; set; }
            public override string ToString()
            {
                return "type: " + this.type + "\ncoordinates: " + this.coordinates;
            }
        }

        public class Properties
        {
            public string province { get; set; }
            public string population { get; set; }
            public string id { get; set; }
            public String name_provider { get; set; }
            public Properties(string province, string population,string id, String name_provider)
            {
                this.province = province;
                this.population = population;
                this.name_provider = name_provider;
                this.id = id;
            }
            public Properties():base()
            {

            }
            public override string ToString()
            {
                return "provincia: " + this.province + "\npoblacion: " + this.population
                   ;
            }
        }

        public class Feature
        {
            public string type { get; set; }
            public Geometry geometry { get; set; }
            public Properties properties { get; set; }
            public Feature() : base() { }
            public Feature(string type, Geometry geometry, Properties properties)
            {
                this.type = type;
                this.geometry = geometry;
                this.properties = properties;
            }
            public override string ToString()
            {
                return "type: " + this.type + "\ngeometry: " + this.geometry.ToString()
                    + "\nproperties : " + this.properties.ToString();
            }
        }

        public class Root
        {
            public string type { get; set; }
            public List<Feature> features { get; set; }

            public override string ToString()
            {
                return "type: " + this.type + "\nfeatures: " + this.features;
            }
        }



    }


}
