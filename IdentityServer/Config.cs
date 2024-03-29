﻿using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId="MoviesClient",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    ClientSecrets=
                    {
                        new Secret("Secret".Sha256())
                    },
                    AllowedScopes={"moviesAPI"}
                },
                new Client
                {
                    ClientId="Customers_mvc_client",
                    ClientName="Customers mvc web app",
                    AllowedGrantTypes=GrantTypes.Code,
                    RedirectUris=new List<string>()
                    {
                        "https://localhost:5005/signin-oidc"
                    },
                    PostLogoutRedirectUris=new List<string>()
                    {
                        "https://localhost:5005/signout-callback-oidc"
                    },
                    ClientSecrets=new List<Secret>
                    {
                        new Secret("Secret".Sha256())
                    },
                    RequirePkce=false,
                    AllowedScopes=new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                    }


                }
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
               new ApiScope("moviesAPI","Movies API")
            };
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        public static List<TestUser> TestUsers =>
            new List<TestUser>
            {
                new TestUser
                {
                    SubjectId="5BE86359-073C-4348-AD2D-A3932222DABE",
                    Username="mehmet",
                    Password="mehmet",
                    Claims=new List<Claim>
                    {
                        new Claim(JwtClaimTypes.GivenName,"mehmet"),
                        new Claim(JwtClaimTypes.FamilyName,"ozkaya")
                    }
                }

            };
    }
}
