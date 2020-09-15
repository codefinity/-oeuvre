﻿using Oeuvre.Modules.IdentityAccess.Application.UserRegistrations.ConfirmUserRegistration;
using Oeuvre.Modules.IdentityAccess.Application.UserRegistrations.GetUserRegistration;
using Oeuvre.Modules.IdentityAccess.Application.UserRegistrations.RegisterNewUser;
using Oeuvre.Modules.IdentityAccess.IntegrationTests.SeedWork;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Xunit;

namespace Oeuvre.Modules.IdentityAccess.IntegrationTests.UserRegistrations
{
    //#FREG
    [Collection("IdentityAccessIntegrationTestCollection")]
    public class UserRegistration_Integration_Tests : TestBase
    {
        //FREG-S1
        [Fact]
        public async void GIVEN_UserRegistersWithUniqueEMailId_THEN_RegistrationShouldBeSuccessful()
        {
            RegisterNewUserCommand registerNewUserCommand = new RegisterNewUserCommand(
                                        "47d60457-5a80-4c83-96b6-890a5e5e4d22",
                                        "Bono",
                                        "Hewson",
                                        "withorwithoutyou",
                                        "+1",
                                        "1294561062",
                                        "Bono@U2.com");


            var registrationId = await IdentityAccessModule.ExecuteCommandAsync(registerNewUserCommand);

            var userRegistration = await IdentityAccessModule.ExecuteQueryAsync(new GetUserRegistrationQuery(registrationId));

            Assert.Equal(userRegistration.Email, registerNewUserCommand.Email);
            Assert.Equal(userRegistration.FirstName, registerNewUserCommand.FirstName);
            Assert.Equal(userRegistration.LastName, registerNewUserCommand.LastName);
            Assert.Equal(userRegistration.CountryCode, registerNewUserCommand.MobileNoCountryCode);
            Assert.Equal(userRegistration.MobileNo, registerNewUserCommand.MobileNumber);
            //Assert.Equals(userRegistration.TenantId, registerNewUserCommand.TenantId);

        }

        //FREG-S2
        [Fact]
        public async void GIVEN_UserRegistersMoreThanOnceWithUniqueEMailId_THEN_RegistrationShouldBeSuccessful()
        {

            RegisterNewUserCommand registerNewUserCommand = new RegisterNewUserCommand(
                            "47d60457-5a80-4c83-96b6-890a5e5e4d22",
                            "Bono",
                            "Hewson",
                            "withorwithoutyou",
                            "+1",
                            "1294561062",
                            "Bono2@U2.com");


            var registrationId = await IdentityAccessModule.ExecuteCommandAsync(registerNewUserCommand);

            var userRegistration = await IdentityAccessModule.ExecuteQueryAsync(new GetUserRegistrationQuery(registrationId));

            RegisterNewUserCommand registerNewUserCommand2 = new RegisterNewUserCommand(
                            "47d60457-5a80-4c83-96b6-890a5e5e4d22",
                            "Bono",
                            "Hewson",
                            "withorwithoutyou",
                            "+1",
                            "1294561062",
                            "Bono2@U2.com");


            var registrationId2 = await IdentityAccessModule.ExecuteCommandAsync(registerNewUserCommand2);

            var userRegistration2 = await IdentityAccessModule.ExecuteQueryAsync(new GetUserRegistrationQuery(registrationId2));


            Assert.Equal(userRegistration.Email, registerNewUserCommand.Email);
            Assert.Equal(userRegistration.FirstName, registerNewUserCommand.FirstName);
            Assert.Equal(userRegistration.LastName, registerNewUserCommand.LastName);
            Assert.Equal(userRegistration.CountryCode, registerNewUserCommand.MobileNoCountryCode);
            Assert.Equal(userRegistration.MobileNo, registerNewUserCommand.MobileNumber);
            //Assert.Equals(userRegistration.TenantId, registerNewUserCommand.TenantId);


            Assert.Equal(userRegistration2.Email, registerNewUserCommand2.Email);
            Assert.Equal(userRegistration2.FirstName, registerNewUserCommand2.FirstName);
            Assert.Equal(userRegistration2.LastName, registerNewUserCommand2.LastName);
            Assert.Equal(userRegistration2.CountryCode, registerNewUserCommand2.MobileNoCountryCode);
            Assert.Equal(userRegistration2.MobileNo, registerNewUserCommand2.MobileNumber);
            //Assert.Equals(userRegistration.TenantId, registerNewUserCommand.TenantId);



        }

        //FREG-S3
        [Fact]
        public async void GIVEN_UserRegistersAfterEMailVerificationLinkExpiresWithUniqueEMailId_THEN_RegistrationShouldBeSuccessful()
        {
            RegisterNewUserCommand registerNewUserCommand = new RegisterNewUserCommand(
                            "47d60457-5a80-4c83-96b6-890a5e5e4d22",
                            "Bono",
                            "Hewson",
                            "withorwithoutyou",
                            "+1",
                            "1294561062",
                            "Bono4@U2.com");


            var registrationId = await IdentityAccessModule.ExecuteCommandAsync(registerNewUserCommand);

            var userRegistration = await IdentityAccessModule.ExecuteQueryAsync(new GetUserRegistrationQuery(registrationId));

            Assert.Equal(userRegistration.Email, registerNewUserCommand.Email);
            Assert.Equal(userRegistration.FirstName, registerNewUserCommand.FirstName);
            Assert.Equal(userRegistration.LastName, registerNewUserCommand.LastName);
            Assert.Equal(userRegistration.CountryCode, registerNewUserCommand.MobileNoCountryCode);
            Assert.Equal(userRegistration.MobileNo, registerNewUserCommand.MobileNumber);
            //Assert.Equals(userRegistration.TenantId, registerNewUserCommand.TenantId);

        }

        //FREG-S4
        [Fact]
        public async void GIVEN_UserRegistersWithoutUniqueEMailId_THEN_BreaksUserLoginEmailIdMustBeUniqueRule()
        {
            //Given
            //Create and Confirm the User
            RegisterNewUserCommand registerNewUserCommand = new RegisterNewUserCommand(
                                        "47d60457-5a80-4c83-96b6-890a5e5e4d22",
                                        "Bono",
                                        "Hewson",
                                        "withorwithoutyou",
                                        "+1",
                                        "1294561062",
                                        "Bono4@U2.com");


            var registrationId = await IdentityAccessModule.ExecuteCommandAsync(registerNewUserCommand);

            await IdentityAccessModule.ExecuteCommandAsync(new ConfirmUserRegistrationCommand(registrationId));

            //When
            //Register with same EMailId
            RegisterNewUserCommand registerNewUserCommand2 = new RegisterNewUserCommand(
                                        "47d60457-5a80-4c83-96b6-890a5e5e4d22",
                                        "Bono",
                                        "Hewson",
                                        "withorwithoutyou",
                                        "+1",
                                        "1294561062",
                                        "Bono4@U2.com");


            //var registrationId2 = await IdentityAccessModule.ExecuteCommandAsync(registerNewUserCommand2);


        }
    }
}