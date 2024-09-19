using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReading
{
    internal class Grafana
    {

        public class Rootobject
        {
            public string time { get; set; }
            public string stream { get; set; }
            public string _p { get; set; }
            public string log { get; set; }
            public Kubernetes kubernetes { get; set; }
        }

        public class Kubernetes
        {
            public string pod_name { get; set; }
            public string namespace_name { get; set; }
            public string pod_id { get; set; }
            public Labels labels { get; set; }
            public Annotations annotations { get; set; }
            public string host { get; set; }
            public string container_name { get; set; }
            public string docker_id { get; set; }
            public string container_hash { get; set; }
            public string container_image { get; set; }
        }

        public class Labels
        {
            public string app { get; set; }
            public string podtemplatehash { get; set; }
            public string securityistioiotlsMode { get; set; }
            public string serviceistioiocanonicalname { get; set; }
            public string serviceistioiocanonicalrevision { get; set; }
        }

        public class Annotations
        {
            public string istioiorev { get; set; }
            public string kubectlkubernetesiodefaultcontainer { get; set; }
            public string kubectlkubernetesiodefaultlogscontainer { get; set; }
            public string prometheusiopath { get; set; }
            public string prometheusioport { get; set; }
            public string prometheusioscrape { get; set; }
            public string sidecaristioiostatus { get; set; }
        }

    }
}
