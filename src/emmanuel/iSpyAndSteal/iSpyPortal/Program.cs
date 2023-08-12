using iSpyPortal.Dashboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpyPortal
{
    public class Item
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Item(int id, string description)
        {
            this.Id = id;
            this.Description = description;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
