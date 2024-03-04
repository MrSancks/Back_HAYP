using scrap.Model;

namespace Hayp.Server.Model
{
    public class AllModels
    {
        public IEnumerable<ModeloCpu> ModeloCpus { get; set; }
        public IEnumerable<ModeloGpu> ModeloGpus { get; set; }
        public IEnumerable<ModeloCase> ModeloCases { get; set; }
        public IEnumerable<ModeloCooler> ModeloCoolers { get; set; }
        public IEnumerable<ModeloMonitor> ModeloMonitors { get; set; }
        public IEnumerable<ModeloPlacas> ModeloPlacas { get; set; }
        public IEnumerable<ModeloPsu> ModeloPsus { get; set; }
        public IEnumerable<ModelosSsd> ModelosSsds { get; set; }
    }
}
