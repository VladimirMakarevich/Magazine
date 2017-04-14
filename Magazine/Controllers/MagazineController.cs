using Magazine.BL.UnityOfWork;
using Magazine.DAL.Entities;
using Magazine.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class MagazineController : BaseController
    {
        private StoreMapper _storeMapper;
        public MagazineController(IUnityOfWork unityOfWork, StoreMapper storeMapper)
        {
            _unityOfWork = unityOfWork;
            _storeMapper = storeMapper;
        }

        public ActionResult Index()
        {
            var store = _unityOfWork.Stores.GetAll();
            var storeViewModel = _storeMapper.ToListStoreViewModel(store);

            return View(storeViewModel);
        }


        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
