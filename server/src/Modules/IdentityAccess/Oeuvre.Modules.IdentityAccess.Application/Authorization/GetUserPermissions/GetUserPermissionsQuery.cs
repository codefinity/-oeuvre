﻿using System;
using System.Collections.Generic;
using Oeuvre.Modules.IdentityAccess.Application.Contracts;

namespace Oeuvre.Modules.IdentityAccess.Application.Authorization.GetUserPermissions
{
    public class GetUserPermissionsQuery : QueryBase, IQuery<List<UserPermissionDto>>
    {
        public GetUserPermissionsQuery(Guid userId)
        {
            UserId = userId;
        }

        public Guid UserId { get; }
    }
}