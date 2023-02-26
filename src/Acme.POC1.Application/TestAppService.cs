using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.POC1
{
    public class TestAppService : POC1AppService, ITestAppService
    {

        public async Task GetExample(GetListInput input)
        {
            await Console.Out.WriteLineAsync(input.Text);
            await Console.Out.WriteLineAsync(input.Date1.ToString());
        }

        public async Task PostExample(GetListInput input, string someAnohterParameter)
        {
            await Console.Out.WriteLineAsync(input.Text);
            await Console.Out.WriteLineAsync(input.Date1.ToString());
        }
    }
}
