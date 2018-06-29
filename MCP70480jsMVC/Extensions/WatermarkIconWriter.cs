using System;
using System.Web;
using System.Web.Routing;

namespace MCP70480jsMVC.Extensions
{
    public class WatermarkIconWriter : IHttpHandler, IRouteHandler
    {
        // カスタムhttphandlerを作成する


        public void ProcessRequest(HttpContext context)
        {
            WatermarkIconWriter writer = new WatermarkIconWriter();

            // 静的ファイルへのルーティングを許可する
            // デフォルトでは許可されていない
            RouteTable.Routes.RouteExistingFiles = true;

            // 追加するルートとデフォルトで使用するインスタンス
            Route imageRoute = new Route("images/{name}", writer);

            // ルートを追加
            RouteTable.Routes.Add("image", imageRoute);
        }

        public bool IsReusable { get; }
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            throw new NotImplementedException();
        }
    }
}