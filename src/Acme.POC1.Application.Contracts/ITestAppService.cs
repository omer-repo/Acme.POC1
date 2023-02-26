using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.POC1
{
    public interface ITestAppService: IApplicationService
    {
        Task GetExample(GetListInput input);
        Task PostExample(GetListInput input, string someAnohterParameter);
    }
}