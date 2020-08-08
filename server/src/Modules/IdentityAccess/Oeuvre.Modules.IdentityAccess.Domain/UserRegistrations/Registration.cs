﻿using System;
using System.Runtime.CompilerServices;
using Domania.Domain;
using Oeuvre.Modules.IdentityAccess.Domain.Tenants;
using Oeuvre.Modules.IdentityAccess.Domain.UserRegistrations.Events;
using Oeuvre.Modules.IdentityAccess.Domain.UserRegistrations.Rules;

namespace Oeuvre.Modules.IdentityAccess.Domain.UserRegistrations
{
    public class Registration : Entity, IAggregateRoot
    {
        public UserRegistrationId Id { get; private set; }

        private TenantId tenantId;

        private FullName fullName;

        private string password;

        private MobileNumber mobileNumber;

        private string eMailId;

        private DateTime registrationDate;

        private UserRegistrationStatus status;

        private DateTime? confirmedDate;

        private Registration()
        {
            // Only EF.
        }

        private Registration(TenantId tenantId, 
                                FullName fullName,
                                string password,
                                MobileNumber mobileNumber,
                                string eMailId,
                                IUsersCounter usersCounter)
        {
            this.CheckRule(new UserLoginMustBeUniqueRule(usersCounter, eMailId));

            this.Id = new UserRegistrationId(Guid.NewGuid());

            this.tenantId = tenantId;
            this.fullName = fullName;
            this.password = password;
            this.mobileNumber = mobileNumber;
            this.eMailId = eMailId;

            registrationDate = DateTime.UtcNow;

            //this.status = 1;
            status = UserRegistrationStatus.WaitingForConfirmation;

            this.AddDomainEvent(new NewUserRegisteredDomainEvent(this.Id,
                                                                    fullName.FirstName,
                                                                    fullName.LastName,
                                                                    mobileNumber.Number,
                                                                    eMailId, 
                                                                    registrationDate));
        }

        public static Registration RegisterNewUser(Guid tenantId,
                                                    string firstName,
                                                     string lastName,
                                                     string password,
                                                     string mobileNoCountryCode,
                                                     string mobileNumber,
                                                     string emailId,
                                                     IUsersCounter usersCounter)
        {
            return new Registration(new TenantId(tenantId), 
                                        new FullName(firstName, lastName),
                                        password,
                                        new MobileNumber(mobileNoCountryCode, mobileNumber),
                                        emailId,
                                        usersCounter);
        }

        //public User CreateUser()
        //{
        //this.CheckRule(new UserCannotBeCreatedWhenRegistrationIsNotConfirmedRule(_status));

        //   return User.CreateFromUserRegistration(this.Id, this._login, this._password, this._email, this._firstName,
        //       this._lastName, this._name);
        //}

        public void Confirm()
        {
            //this.CheckRule(new UserRegistrationCannotBeConfirmedMoreThanOnceRule(_status));
            //this.CheckRule(new UserRegistrationCannotBeConfirmedAfterExpirationRule(_status));

            //status = UserRegistrationStatus.Confirmed;
            confirmedDate = DateTime.UtcNow;

            //this.AddDomainEvent(new UserRegistrationConfirmedDomainEvent(this.Id));
        }

        public void Expire()
        {
            //this.CheckRule(new UserRegistrationCannotBeExpiredMoreThanOnceRule(_status));

            //status = UserRegistrationStatus.Expired;

            //this.AddDomainEvent(new UserRegistrationExpiredDomainEvent(this.Id));
        }
    }
}