using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;


namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class ManageTest
    {
        [TestMethod]
        public void TestIndex()
        {
            var controller = new ManageController();
            var result = controller.Index() as ViewResult;
           
            var db = new cs4peEntities();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<BangSanPham>));
          
            Assert.AreEqual(db.BangSanPhams.Count(), ((List<BangSanPham>)result.Model).Count);
        }
    }
}
