﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNetCore.Security.CAS
{
    /// <summary>
    /// Base class for other CAS contexts.
    /// </summary>
    public class BaseCasContext : BaseContext
    {
        /// <summary>
        /// Initializes a <see cref="BaseCasContext"/>
        /// </summary>
        /// <param name="context">The HTTP environment</param>
        /// <param name="options">The options for Cas</param>
        public BaseCasContext(HttpContext context, CasOptions options)
            : base(context)
        {
            Options = options;
        }

        public CasOptions Options { get; }
    }
}