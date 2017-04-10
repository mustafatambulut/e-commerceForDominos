using e_commerceForDominos.Models;
using System;

namespace e_commerceForDominos.NhibernateMappingFile
{
    public class Feature{
        
        public virtual Int64 USER_ID { get; set;}
        public virtual String USER_NAME { get; set; }
        public virtual String PASSWORD { get; set; }
 
    }

    //public partial class FeatureImpl : Feature { }

}