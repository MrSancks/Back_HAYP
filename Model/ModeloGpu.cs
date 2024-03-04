using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrap.Model
{
    public class ModeloGpu : IModelo
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? Nombre { get; set; }
        public string? Precio { get; set; }
        public string? Descripcion { get; set; }
        public string? image { get; set; }
    }
}
