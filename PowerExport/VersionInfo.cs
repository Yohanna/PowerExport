using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerExport
{
    public class VersionsInfo
    {
        public string versionName;
        public string location;
        public bool installed;
        public string currentResolution;

        public VersionsInfo(string version, string location, string currentResolution, bool installed)
    {
        this.versionName = version;
        this.location = location;
        this.currentResolution = currentResolution;
        this.installed = installed;
    }

    }
}
