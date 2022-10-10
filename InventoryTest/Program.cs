using System;
using System.Windows.Forms;
using Unity;

namespace InventoryTest
{
    static partial class Program
    {
        private static IUnityContainer container;

        [STAThread]
        static void Main()
        {
            ConfigureAutoMapper();
            ConfigureDI();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<InventoryForm>());
        }
    }
}
