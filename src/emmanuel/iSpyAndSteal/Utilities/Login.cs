using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{


	public static class LoginManagment
	{
        public static long SYSTEM_ID { get; set; }
        public static string UserID { get; set; }
        public static string UserName { get; set; }

        public static int Timer { get; set; }
		public static int? DEPT { get; set; }

		public static bool IsLogin { get; set; }
        public static string FpTemplate { get; set; }

        public static bool IsAdmin { get; set; }
        public static string AuthMessage { get; set; }
        public static string MAC_ADDRESS { get; set; }
        public static int IDLE_TIME_OUT_HOUR { get;  set; }
		public static int IDLE_TIME_OUT_MIN { get;  set; }

        public static List<PrivsList> PrivsList { get; set; }


        public static void Dispose()
		{
			UserID = null;
			UserName = null;
			IsLogin = false;
			FpTemplate = null;
			//AuthMode = null;
		}

		
	}
}
