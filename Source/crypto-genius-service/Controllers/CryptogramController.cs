﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crypto.Genius.Service.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace crypto.genius.service.Controllers
{
    [Route("api/[controller]")]
    public class CryptogramController : Controller
    {
        // GET: api/values
        [HttpGet]
        public Cryptogram Get()
        {
            Cryptogram crypto = new Cryptogram();
            crypto.GenerateModelPartidaEmpatada();
            return crypto;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Cryptogram Get(int id)
        {
            return new Cryptogram();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
