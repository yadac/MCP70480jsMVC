using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;
using System.Web.WebSockets;

namespace MCP70480jsMVC.Extensions
{
    public class SocketHandler : IHttpHandler, IRouteHandler
    {
        // IRouterHandler
        // 登録されているルートに一致していたらGetHttpHandlerが呼ばれる

        public const int BufferSize = 1024;
        public RequestContext rContext;

        async Task EchoLoop(AspNetWebSocketContext context)
        {
            var socket = context.WebSocket;
            var buffer = new Byte[BufferSize];
            var segment = new ArraySegment<byte>(buffer);

            while (socket.State == WebSocketState.Open)
            {
                var incoming = await socket.ReceiveAsync(segment, CancellationToken.None);
                var outgoing = new ArraySegment<byte>(buffer, 0, incoming.Count);
                await socket.SendAsync(outgoing, WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            //if (context.IsWebSocketRequest)
            //{
            //    context.AcceptWebSocketRequest(EchoLoop);
            //}
            context.Response.ContentType = "text/plain";
            if (rContext.RouteData != null)
            {
                string pid = rContext.RouteData.Values["productid"].ToString();
                context.Response.Write(pid);
            }
        }

        public bool IsReusable
        {
            get { return true; }
        }

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new SocketHandler() { rContext = requestContext };
        }
    }
}