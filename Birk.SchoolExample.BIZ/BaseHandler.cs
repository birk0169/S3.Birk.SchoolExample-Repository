using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    abstract public class BaseHandler
    {
        //Field
        private SchoolExampleModel model;

        //Constructor
        public BaseHandler()
        {
            Model = new SchoolExampleModel();
        }

        //Properties
        protected SchoolExampleModel Model { get => model; set => model = value; }
    }

    
}
