using Newtonsoft.Json;
using Starcounter;
using System;

namespace JsonDemo
{
    class HandlerWrapper
    {
        public static void POST<T>(string url, Func<T, Response> code)
        {
            Handle.POST<Request>(url, (request) =>
            {
                if (typeof(T) != typeof(Request))
                {
                    var req = request as Request;
                    var obj = JsonConvert.DeserializeObject<T>(req.Body);
                    return code(obj);
                }
                else
                {
                    return code((T)Convert.ChangeType(request, typeof(T)));
                }

            });
        }

        public static Response GetResponse<T>(T obj)
        {
            return new Response()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Body = JsonConvert.SerializeObject(obj),
            };
        }
    }
}
