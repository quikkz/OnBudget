﻿using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;

using OnBudget.MobileAppService.DataObjects;
using OnBudget.MobileAppService.Models;

namespace OnBudget.MobileAppService.Controllers
{
    // TODO: Uncomment [Authorize] attribute to require user be authenticated to access Item(s).
    [Authorize]
    public class UserController : TableController<User>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MasterDetailContext context = new MasterDetailContext();
            DomainManager = new EntityDomainManager<User>(context, Request);
        }

        // GET tables/User
        public IQueryable<User> GetAllUsers()
        {
            return Query();
        }

        // GET tables/User/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<User> GetUser(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/User/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<User> PatchUser(string id, Delta<User> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/User
        public async Task<IHttpActionResult> PostUser(User user)
        {
            User current = await InsertAsync(user);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/User/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUser(string id)
        {
            return DeleteAsync(id);
        }
    }
}