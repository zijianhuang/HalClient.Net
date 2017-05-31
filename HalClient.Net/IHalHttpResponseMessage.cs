using System.Net.Http;
using HalClient.Net.Parser;

namespace HalClient.Net
{
	public interface IHalHttpResponseMessage
	{
		HttpResponseMessage Message { get; }
		bool IsHalResponse { get; }
        bool IsJsonResponse { get; }
        IRootResourceObject Resource { get; }
	}
}