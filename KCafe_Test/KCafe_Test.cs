using System;
using System.Collections.Generic;
using Insurance_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KCafe_Test
{
    [TestClass]
    public class KCafe_Test
    {
        [TestMethod]

        public void AddToDirectory()
        {
            MenuContent content = new MenuContent();
            KCafe_Repo repository = new KCafe_Repo();

            bool addResult = repository.AddContentToDirectory(content);

            Assert.IsTrue(addResult);
        }

        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            MenuContent content = new MenuContent();
            KCafe_Repo repository = new KCafe_Repo();

            repository.AddContentToDirectory(content);

            List<MenuContent> contents = repository.GetContents();

            bool directoryHasContents = contents.Contains(content);
            Assert.IsTrue(directoryHasContents);

        }

        private KCafe_Repo _repo;
        private MenuContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new KCafe_Repo();
            _content = new MenuContent( );
            _repo.AddContentToDirectory(_content);

        }
    }
}
