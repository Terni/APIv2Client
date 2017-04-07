using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoin.APIv2Client
{
    public static class APIv2Client_ST
    {
        private static APIv2Client _apIv2Client;

        static APIv2Client_ST()
        {
            _apIv2Client = new APIv2Client();
        }

        public static APIv2Client Tools{
            get { return _apIv2Client; }
            set { value = _apIv2Client; }
        }
    }
}
