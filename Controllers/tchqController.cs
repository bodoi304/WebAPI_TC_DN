using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HQrefer;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using static HQrefer.HQServiceSoapClient;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class tchqController : ControllerBase
    {

       
        [HttpPost]
        public ActionResult<string> TraCuuTTNopThue(postObject obj)
        {
            HQServiceSoapClient wSHQ = new HQServiceSoapClient(EndpointConfiguration.HQServiceSoap);
            Task<TraCuuTTNopThueResponse> objRes= wSHQ.TraCuuTTNopThueAsync(obj.maDN, obj.soTK);
            TraCuuTTNopThueResponse result = objRes.Result;
            TraCuuTTNopThueResponseBody a = result.Body;
            string b = a.TraCuuTTNopThueResult;
            return b;
        }

        [HttpPost]
        public ActionResult<string> TraCuuTTToKhaiHaiQuan(postObject obj)
        {
            HQServiceSoapClient wSHQ = new HQServiceSoapClient(EndpointConfiguration.HQServiceSoap);
            Task<TraCuuTTToKhaiHaiQuanResponse> objRes= wSHQ.TraCuuTTToKhaiHaiQuanAsync(obj.maDN, obj.soTK,obj.cmnd);
            TraCuuTTToKhaiHaiQuanResponse result = objRes.Result;
            TraCuuTTToKhaiHaiQuanResponseBody a = result.Body;
            string b = a.TraCuuTTToKhaiHaiQuanResult;
            return b;
        }
    }
}
