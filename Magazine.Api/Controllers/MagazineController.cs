using Magazine.BL.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Magazine.Api.Controllers
{
    public class MagazineController : ApiController
    {
        private IUnityOfWork _unityOfWork;
        //private StoreMapper _storeMapper;
        //private ItemMapper _itemMapper;

        public MagazineController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
            //_storeMapper = storeMapper;
            //_itemMapper = itemMapper;
        }
        // GET: api/Magazine
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Magazine/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Magazine
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Magazine/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Magazine/5
        public void Delete(int id)
        {
        }
    }
}
