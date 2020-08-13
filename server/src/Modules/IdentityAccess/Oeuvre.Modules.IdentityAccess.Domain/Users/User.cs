﻿using Domania.Domain;
using Oeuvre.Modules.IdentityAccess.Domain.Tenants;
using Oeuvre.Modules.IdentityAccess.Domain.UserRegistrations;
using Oeuvre.Modules.IdentityAccess.Domain.Users.Events;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Oeuvre.Modules.IdentityAccess.Domain.Users
{
    public class User : Entity, IAggregateRoot
    {
        public UserId Id { get; private set; }

        private TenantId tenantId;

        private FullName fullName;

        private MobileNumber mobileNumber;

        private string eMailId;

        private string password;

        //private List<UserRole> roles;

        private bool isActive;


        private User()
        {

        }

        internal static User CreateFromUserRegistration(UserRegistrationId userRegistrationId,
                                                        TenantId tenantId,
                                                        string firstName,
                                                        string lastName,
                                                        string countryCode,
                                                        string mobileNumber,
                                                        string eMailId,
                                                        string password)
        {
            return new User(userRegistrationId, 
                                tenantId, 
                                new FullName(firstName, lastName), 
                                new MobileNumber(countryCode, mobileNumber),
                                eMailId, 
                                password);
        }

        private User(UserRegistrationId userRegistrationId,
                        TenantId tenantId,
                        FullName fullName,
                        MobileNumber mobileNumber,
                        string eMailId,
                        string password)
        {
            this.Id = new UserId(userRegistrationId.Value);
            this.tenantId = tenantId;
            this.fullName = fullName;
            this.mobileNumber = mobileNumber;
            this.password = password;
            this.eMailId = eMailId;
            this.password = password;
            this.isActive = true;

            //this.roles = new List<UserRole>();
            //this.roles.Add(UserRole.Member);

            this.AddDomainEvent(new UserCreatedDomainEvent(this.Id));
        }
    }
}
