<<<<<<< HEAD
﻿using System;
=======
﻿using Jitter.Models;
using Microsoft.AspNet.Identity;
using System;
>>>>>>> 4edeb1fa679168e0ca6b2a99e69dbb6b4b1e00b7
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jitter.Controllers
{
    public class TestController : ApiController
    {
<<<<<<< HEAD
=======
        public JitterRepository Repo { get; set; }

        public TestController() : base()
        {
            Repo = new JitterRepository();
        }

>>>>>>> 4edeb1fa679168e0ca6b2a99e69dbb6b4b1e00b7
        // GET: api/Test
        public string Get()
        {
            return "Hello, is it me you're looking for?";
        }
<<<<<<< HEAD

=======
>>>>>>> 4edeb1fa679168e0ca6b2a99e69dbb6b4b1e00b7
        /*
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
<<<<<<< HEAD
        }
        */
=======
        }*/
>>>>>>> 4edeb1fa679168e0ca6b2a99e69dbb6b4b1e00b7

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

<<<<<<< HEAD
=======
        public void Delete()
        {
            string user_id = User.Identity.GetUserId();
            ApplicationUser real_user = Repo.Context.Users.FirstOrDefault(u => u.Id == user_id);

            if (real_user.Email.Contains("example.com")) {
                Repo.DeleteAllUsers();
            }
        }

>>>>>>> 4edeb1fa679168e0ca6b2a99e69dbb6b4b1e00b7
        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
