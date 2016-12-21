using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sirha.ViewModel;

namespace Sirha.UnitTest
{
    [TestClass]
    public class AccueilUnitTest
    {
        [TestMethod]
        [TestCategory("CanSearch")]
        public void CanSearch_AllVariableEmpty_Test()
        {
            //Initialisation variable
            var vm = new AccueilViewModel();
            vm.Adresse = "";
            vm.CodePostal = "";
            vm.Commercial = "";
            vm.Nom = "";
            vm.Region = "";
            vm.Ville = "";
            //éxécution méthode
            var result = vm.CanSearch();
            //test
            Assert.IsTrue(result == false, "La fonction doit retournée false");
        }

        [TestMethod]
        [TestCategory("CanSearch")]
        public void CanSearch_OneVariableNotEmpty_Test()
        {
            //Initialisation variable
            var vm = new AccueilViewModel();
            vm.Adresse = "test";
            vm.CodePostal = "";
            vm.Commercial = "";
            vm.Nom = "";
            vm.Region = "";
            vm.Ville = "";
            //éxécution méthode
            bool result = vm.CanSearch();
            //test
            Assert.IsTrue(result == false, "La fonction doit retournée true");
        }
    }
}
