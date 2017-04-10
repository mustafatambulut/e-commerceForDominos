using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_commerceForDominos.Controllers
{
    public class FeatureSearchController : Controller
    {
        // GET: FeatureSearch
        private readonly e_commerceForDominos.DataAccessLayer.IFeatureDao _featureDao;
        public FeatureSearchController() {
            _featureDao = new e_commerceForDominos.DataAccessLayer.FeatureDoaImpl();
        }

        //public JsonResult GetCounties(string stateName) {
        //    List<string> counties = _featureDao.GetCountiesByStateName(stateName);
        //    return Json(counties, JsonRequestBehavior.AllowGet);

        //}
        //public ActionResult Index()
        //{
        //    var states = _featureDao.GetAllStates();
        //    var stateListItem = (from state in states
        //                         select new SelectListItem
        //                         {
        //                             Text = state, Value = state
        //                         }).ToList();
        //    UsStateViewModel stateModel = new UsStateViewModel { UsStates = stateListItem };
        //    return View();
        //}
    }
}