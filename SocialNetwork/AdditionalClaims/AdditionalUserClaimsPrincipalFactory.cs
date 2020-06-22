using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SocialNetwork.Models.Users;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

/*
 * Utilized to add custom claims to the identity user.
 */
namespace SocialNetwork.AdditionalClaims
{
	public class AdditionalUserClaimsPrincipalFactory
		: UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
	{
		public AdditionalUserClaimsPrincipalFactory(
			UserManager<ApplicationUser> userManager,
			RoleManager<IdentityRole> roleManager,
			IOptions<IdentityOptions> optionsAccessor)
			: base(userManager, roleManager, optionsAccessor)
		{ }

		public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
		{
			var principal = await base.CreateAsync(user);
			var identity = (ClaimsIdentity)principal.Identity;

            /*
			 * This is where we add our custom claims
			 */
            var claims = new List<Claim>
            {
                new Claim("FirstName", user.FirstName),
                new Claim("LastName", user.LastName)
            };

            identity.AddClaims(claims);

			return principal;
		}
	}
}
