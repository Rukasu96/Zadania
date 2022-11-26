using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class Application
    {
        private IDataSource dataSource;
        private IDisplay display;
        private IFile file;

        public Application(IDataSource datasource, IDisplay display, IFile file)
        {
            this.dataSource = datasource;
            this.display = display;
            this.file = file;
        }

        public async Task Run()
        {
            var data = await dataSource.GetData();
            display.Show(data);
            file.Save("dane", data);
        }
    }
}
