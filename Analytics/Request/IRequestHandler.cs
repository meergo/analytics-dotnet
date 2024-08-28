using System.Threading.Tasks;
using Meergo.Model;

namespace Meergo.Request
{
    internal interface IRequestHandler
    {
        Task MakeRequest(Batch batch);
    }
}
