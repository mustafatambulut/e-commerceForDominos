using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_commerceForDominos.DataAccessLayer;
using e_commerceForDominos.NhibernateMappingFile;

namespace e_commerceForDominos.Controllers
{
    public class FeatureController : Controller
    {

        private IFeatureDao _featureDao;

        public FeatureController() {
            _featureDao = new FeatureDoaImpl();
        }

        public List<Feature> login(string userName, string password) {
          return _featureDao.login(userName,password);     
        }

        public void saveFeature(Feature f) {
            _featureDao.saveFeature(f);
        }
        public ActionResult Index()
        {
            return View();
        }

        
    }
}