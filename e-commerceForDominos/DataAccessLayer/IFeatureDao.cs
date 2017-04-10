using e_commerceForDominos.NhibernateMappingFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerceForDominos.DataAccessLayer
{
    public interface IFeatureDao
    {
        List<string> GetAllUs();

        List<string> GetCountiesByStateName();

        List<Feature> login(string userName, string password);

        void saveFeature(Feature f);
    }
}
