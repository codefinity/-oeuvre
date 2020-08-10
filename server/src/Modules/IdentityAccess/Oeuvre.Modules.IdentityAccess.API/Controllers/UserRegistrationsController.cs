﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oeuvre.Modules.IdentityAccess.Application.Contracts;
using Oeuvre.Modules.IdentityAccess.Application.UserRegistrations.ConfirmUserRegistration;
using Oeuvre.Modules.IdentityAccess.Application.UserRegistrations.GetUserRegistration;
using Oeuvre.Modules.IdentityAccess.Application.UserRegistrations.RegisterNewUser;

namespace Oeuvre.Modules.IdentityAccess.API.Controller
{
    [Route("userAccess/[controller]")]
    [ApiController]
    public class UserRegistrationsController : ControllerBase
    {
        private readonly IUserAccessModule userAccessModule;

        public UserRegistrationsController(IUserAccessModule userAccessModule)
        {
            this.userAccessModule = userAccessModule;
        }

        [AllowAnonymous]
        [HttpPost("/identityaccess/register")]
        public async Task<IActionResult> RegisterNewUser(RegisterNewUserRequest request)
        {
            try
            {
                await userAccessModule.ExecuteCommandAsync(new RegisterNewUserCommand(
                                                                        request.TenantId,
                                                                        request.Password,
                                                                        request.EMail,
                                                                        request.FirstName,
                                                                        request.MobileNoCountryCode,
                                                                        request.MobileNumber,
                                                                        request.LastName));
            }
            catch (Exception ex)
            {
                throw;
            }

            return Ok();
        }

        [HttpGet("/identityaccess/registrants")]
        //[HasPermission(MeetingsPermissions.GetAllMeetingGroups)]
        public async Task<IActionResult> GetAllRegisteredUsers()
        {
            var registrantsList = await userAccessModule.ExecuteQueryAsync(new GetAllUserRegistrationQuery());

            return Ok(registrantsList);
        }

        [HttpGet("/identityaccess/registrant/{registrantId}")]
        //[HasPermission(MeetingsPermissions.GetMeetingGroupProposals)]
        public async Task<IActionResult> GetARegisteredUser(Guid registrantId)
        {
            var registrant = await userAccessModule.ExecuteQueryAsync(new GetUserRegistrationQuery(registrantId));

            return Ok(registrant);
        }


        [AllowAnonymous]
        [HttpPatch("{registrantId}/confirm")]
        public async Task<IActionResult> ConfirmRegistration(Guid registrantId)
        {
            await userAccessModule.ExecuteCommandAsync(new ConfirmUserRegistrationCommand(registrantId));

            return Ok();
        }
    }
}
