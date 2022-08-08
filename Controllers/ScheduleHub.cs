using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class ScheduleHub : Hub
    {
        public async Task Modify(string action, object data)
        {
            await Clients.Others.modify(action, data);
        }
    }
}