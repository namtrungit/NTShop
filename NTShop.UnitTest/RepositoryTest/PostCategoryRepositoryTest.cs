using Microsoft.VisualStudio.TestTools.UnitTesting;
using NTShop.Data.InfraStructure;
using NTShop.Data.Respositories;
using NTShop.Model.Model;
using System.Linq;

namespace NTShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWord;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWord = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_Get()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "TestName";
            category.Alias = "TestAlias";
            category.Status = true;
            var result = objRepository.Add(category);
            unitOfWord.Commit();


            //2 phương thức assert này phải = true thì phương thức trên sẽ pass
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.ID);
        }
    }
}