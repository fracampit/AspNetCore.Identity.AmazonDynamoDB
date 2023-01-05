﻿namespace AspNetCore.Identity.AmazonDynamoDB.Tests;

internal class Constants
{
  public const string DatabaseCollection = "DatabaseDependent";

  public const string DefaultUsersTableName = "identity.users";
  public const string DefaultUserClaimsTableName = "identity.user_claims";
  public const string DefaultUserLoginsTableName = "identity.user_logins";
  public const string DefaultUserRolesTableName = "identity.user_roles";
  public const string DefaultUserTokensTableName = "identity.user_tokens";
}
