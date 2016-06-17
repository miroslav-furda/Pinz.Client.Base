using Com.Pinz.Client.DomainModel;
using Com.Pinz.Client.RemoteServiceConsumer.Callback;
using Com.Pinz.Client.RemoteServiceConsumer.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using Pinz.Client.RemoteServiceConsumer.IntegrationTest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;

namespace Com.Pinz.Client.RemoteServiceConsumer.Administration
{
    [TestClass]
    public class UserServiceFixture
    {
        private IPinzAdminRemoteService pinzService;
        private IAdministrationRemoteService service;
        private IKernel kernel;
        private Company company;

        [TestInitialize]
        public void InitializeKernel()
        {
            kernel = new StandardKernel();
            kernel.Load(new ServiceConsumerNinjectModule());
            Mock<IServiceRunningIndicator> servMock = new Mock<IServiceRunningIndicator>();
            kernel.Bind<IServiceRunningIndicator>().ToConstant(servMock.Object);

            service = kernel.Get<IAdministrationRemoteService>();
            pinzService = kernel.Get<IPinzAdminRemoteService>();

            UserNameClientCredentials credentials = kernel.Get<UserNameClientCredentials>();
            credentials.UserName = TestUserCredentials.UserName;
            credentials.Password = TestUserCredentials.Password;
            credentials.UpdateCredentialsForAllFactories();

            Company company1 = new Company()
            {
                Name = "Pinz Online"
            };
            company = pinzService.CreateCompany(company1);
        }

        [TestCleanup()]
        public void UnloadKernel()
        {
            pinzService.DeleteCompany(company);

            kernel.Dispose();
        }

        [TestMethod]
        public void CreateUser()
        {
            Assert.AreNotEqual(Guid.Empty, company.CompanyId);

            User user = new User();
            user.EMail = "me@hotmail.sk";
            user.IsCompanyAdmin = true;
            user.CompanyId = company.CompanyId;
            user.FirstName = "Miro";
            user.FamilyName = "Furda";

            service.CreateUser(user);

            Assert.IsNotNull(user.UserId);
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ExceptionDetail>), "Validation failed.")]
        public void CreateUser_ValidationFailed()
        {
            Assert.AreNotEqual(Guid.Empty, company.CompanyId);

            User user = new User();
            user.EMail = null;
            user.IsCompanyAdmin = true;
            user.CompanyId = company.CompanyId;
            user.FirstName = "Miro";
            user.FamilyName = "Furda";

            service.CreateUser(user);
        }

        [TestMethod]
        public void UpdateUser()
        {
            Assert.AreNotEqual(Guid.Empty, company.CompanyId);

            User user = new User();
            user.EMail = "me@hotmail.com";
            user.IsCompanyAdmin = true;
            user.CompanyId = company.CompanyId;
            user.FirstName = "Miro";
            user.FamilyName = "Furda";

            service.CreateUser(user);
            Assert.IsNotNull(user.UserId);

            user.FamilyName = "Neungamat";
            service.UpdateUser(user);

            List<User> users = service.ReadAllUsersForCompany(company.CompanyId);
            Assert.AreEqual(1, users.Count());
            Assert.AreEqual(user.FamilyName, users[0].FamilyName);
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ExceptionDetail>), "Validation failed.")]
        public void UpdateUser_ValidationFailed()
        {
            Assert.AreNotEqual(Guid.Empty, company.CompanyId);

            User user = new User();
            user.EMail = "me@hotmail.com";
            user.IsCompanyAdmin = true;
            user.CompanyId = company.CompanyId;
            user.FirstName = "Miro";
            user.FamilyName = "Furda";

            service.CreateUser(user);
            Assert.IsNotNull(user.UserId);

            user.EMail = null;
            service.UpdateUser(user);
        }

        [TestMethod]
        public void DeleteUser()
        {
            Assert.AreNotEqual(Guid.Empty, company.CompanyId);

            User user = new User();
            user.EMail = "me@hotmail.com";
            user.IsCompanyAdmin = true;
            user.CompanyId = company.CompanyId;
            user.FirstName = "Miro";
            user.FamilyName = "Furda";

            service.CreateUser(user);
            Assert.IsNotNull(user.UserId);

            service.DeleteUser(user);
            List<User> users = service.ReadAllUsersForCompany(company.CompanyId);
            Assert.AreEqual(0, users.Count());
        }

    }
}
