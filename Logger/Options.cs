using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger {
    public class Options {
        public string SavePath { get; set; }
        public List<App> BlockedApplications { get; set; }
        public string FlagWord { get; set; }
        public bool isKeyLogger { get; set; } = true;
    }
}
