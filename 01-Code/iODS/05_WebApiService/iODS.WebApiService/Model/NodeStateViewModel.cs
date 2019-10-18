using System;

namespace iODS.WebApiService.Model
{
    public class NodeStateViewModel
    {
        public string ID { get; set; }
        public string nNodePCID { get; set; }
        public int nCPULoad { get; set; }
        public double fTemperature { get; set; }
        public int nMemoryLoad { get; set; }
        public int nState { get; set; }
        public string StateName { get; set; }
        public int nNodeType { get; set; }
        public string NodeTypeName { get; set; }
        public DateTime strStateTime { get; set; }
        public int IsHaveDetail { get; set; }
    }
}
