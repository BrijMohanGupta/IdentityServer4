// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


namespace IdentityServer4.Configuration
{
    /// <summary>
    /// Options for Mutual TLS features
    /// </summary>
    public class MutualTlsOptions
    {
        // todo: reconcile this vs. DI services style
        public bool Enabled { get; set; }

        public string ClientCertificateAuthenticationScheme { get; set; } = "Certificate";
    }
}