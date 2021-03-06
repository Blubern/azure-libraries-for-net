// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update;
    using Microsoft.Azure.Management.Network.Fluent.HasCookieBasedAffinity.UpdateDefinition;
    using Microsoft.Azure.Management.Network.Fluent.HasServerNameIndication.UpdateDefinition;
    using Microsoft.Azure.Management.Network.Fluent.HasHostName.UpdateDefinition;
    using Microsoft.Azure.Management.Network.Fluent.HasSslCertificate.UpdateDefinition;

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to specify the frontend for the rule to apply to.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithFrontend<ParentT>
    {
        /// <summary>
        /// Enables the rule to apply to the application gateway's private (internal) frontend.
        /// If the private frontend IP configuration does not yet exist, it will be created under an auto-generated name.
        /// If the application gateway does not have a subnet specified for its private frontend, one will be created automatically,
        /// unless a specific subnet is specified in the application gateway definition's optional settings.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithFrontendPort<ParentT> FromPrivateFrontend();

        /// <summary>
        /// Enables the rule to apply to the application gateway's public (Internet-facing) frontend.
        /// If the public frontend IP configuration does not yet exist, it will be created under an auto-generated name.
        /// If the application gateway does not have a public IP address specified for its public frontend, one will be created
        /// automatically, unless a specific public IP address is specified in the application gateway definition's optional settings.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithFrontendPort<ParentT> FromPublicFrontend();
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to add an address to the backend used by this request routing rule.
    /// A new backend will be created if none is associated with this rule yet.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithBackendAddress<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddressBeta<ParentT>
    {
        /// <summary>
        /// Adds an IP address to the backend associated with this rule.
        /// If no backend has been associated with this rule yet, a new one will be created with an auto-generated name.
        /// This call can be used in a sequence to add multiple IP addresses.
        /// </summary>
        /// <param name="ipAddress">An IP address.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddressOrAttach<ParentT> ToBackendIPAddress(string ipAddress);

        /// <summary>
        /// Adds an FQDN (fully qualified domain name) to the backend associated with this rule.
        /// If no backend has been associated with this rule yet, a new one will be created with an auto-generated name.
        /// This call can be used in a sequence to add multiple FQDNs.
        /// </summary>
        /// <param name="fqdn">A fully qualified domain name.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddressOrAttach<ParentT> ToBackendFqdn(string fqdn);
    }

    /// <summary>
    /// The final stage of an application gateway request routing rule definition.
    /// At this stage, any remaining optional settings can be specified, or the definition
    /// can be attached to the parent application gateway definition.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithAttach<ParentT> :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update.IInUpdate<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithHostName<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithCookieBasedAffinity<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithRedirectConfig<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to specify the backend HTTP settings configuration
    /// to associate the routing rule with.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithBackendHttpConfiguration<ParentT>
    {
        /// <summary>
        /// Associates the specified backend HTTP settings configuration with this request routing rule.
        /// If the backend configuration does not exist yet, it must be defined in the optional part of the application gateway
        /// definition. The request routing rule references it only by name.
        /// </summary>
        /// <param name="name">The name of a backend HTTP settings configuration.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendOrAddress<ParentT> ToBackendHttpConfiguration(string name);

        /// <summary>
        /// Creates a backend HTTP settings configuration for the specified backend port and the HTTP protocol, and associates it with this
        /// request routing rule.
        /// An auto-generated name will be used for this newly created configuration.
        /// </summary>
        /// <param name="portNumber">The port number for a new backend HTTP settings configuration.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendOrAddress<ParentT> ToBackendHttpPort(int portNumber);
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to specify an existing listener to
    /// associate the routing rule with.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithListener<ParentT>
    {
        /// <summary>
        /// Associates the request routing rule with a frontend listener.
        /// If the listener with the specified name does not yet exist, it must be defined separately in the optional part
        /// of the application gateway definition. This only adds a reference to the listener by its name.
        /// Also, note that a given listener can be used by no more than one request routing rule at a time.
        /// </summary>
        /// <param name="name">The name of a listener to reference.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigOrRedirect<ParentT> FromListener(string name);
    }

    /// <summary>
    /// The stage of an application gateway request routing rule allowing to enable cookie based affinity.
    /// </summary>
    /// <typeparam name="ParentT">The next stage of the definition.</typeparam>
    public interface IWithCookieBasedAffinity<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.HasCookieBasedAffinity.UpdateDefinition.IWithCookieBasedAffinity<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithAttach<ParentT>>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to require server name indication if the
    /// application gateway is serving multiple websites in its backends and SSL is required.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithBackendHttpConfigurationOrSni<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfiguration<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.HasServerNameIndication.UpdateDefinition.IWithServerNameIndication<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfiguration<ParentT>>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to specify the host name of a backend website
    /// for the listener to receive traffic for.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithHostName<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.HasHostName.UpdateDefinition.IWithHostName<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithAttach<ParentT>>
    {
    }

    /// <summary>
    /// The entirety of an application gateway request routing rule definition as part of an application gateway update.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IUpdateDefinition<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IBlank<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithAttach<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithFrontend<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithListener<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithFrontendPort<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithListenerOrFrontend<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackend<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddress<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendOrAddress<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddressOrAttach<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfiguration<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigOrRedirect<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigurationOrSni<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigOrSniOrRedirect<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithSslCertificate<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithSslPassword<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigOrSniOrRedirect<ParentT>>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule allowing to specify backend HTTP settings, or SNI, or a redirect configuration.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway update to return to after attaching this definition.</typeparam>
    public interface IWithBackendHttpConfigOrSniOrRedirect<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigurationOrSni<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithRedirectConfig<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to require server name indication.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithServerNameIndication<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.HasServerNameIndication.UpdateDefinition.IWithServerNameIndication<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithAttach<ParentT>>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to specify the backend to associate the routing rule with.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithBackend<ParentT>
    {
        /// <summary>
        /// Associates the request routing rule with a backend on this application gateway.
        /// If the backend does not yet exist, it will be automatically created.
        /// </summary>
        /// <param name="name">The name of an existing backend.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithAttach<ParentT> ToBackend(string name);
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to select either a backend or a redirect configuration.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway update to return to after attaching this definition.</typeparam>
    public interface IWithBackendHttpConfigOrRedirect<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfiguration<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithRedirectConfig<ParentT>
    {
    }

    /// <summary>
    /// The first stage of an application gateway request routing rule definition.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IBlank<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithListenerOrFrontend<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to associate an existing listener
    /// with the rule, or create a new one implicitly by specifying the frontend to listen to.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithListenerOrFrontend<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithListener<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithFrontend<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to add an address to specify an existing
    /// backend to associate with this request routing rule or create a new backend with an auto-generated name and addresses to it.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithBackendOrAddress<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackend<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddress<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule allowing to specify an SSL certificate.
    /// </summary>
    /// <typeparam name="ParentT">The next stage of the definition.</typeparam>
    public interface IWithSslCertificate<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.HasSslCertificate.UpdateDefinition.IWithSslCertificate<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigOrSniOrRedirect<ParentT>>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule allowing to specify an SSL certificate.
    /// </summary>
    /// <typeparam name="ParentT">The next stage of the definition.</typeparam>
    public interface IWithSslPassword<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.HasSslCertificate.UpdateDefinition.IWithSslPassword<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to associate the rule with a redirect configuration.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway update to return to after attaching this definition.</typeparam>
    public interface IWithRedirectConfig<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithRedirectConfigBeta<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to create an associate listener and frontend
    /// for a specific port number and protocol.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithFrontendPort<ParentT>
    {
        /// <summary>
        /// Associates a new listener for the specified port number and the HTTPS protocol with this rule.
        /// </summary>
        /// <param name="portNumber">The port number to listen to.</param>
        /// <return>The next stage of the definition, or null if the specified port number is already used for a different protocol.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithSslCertificate<ParentT> FromFrontendHttpsPort(int portNumber);

        /// <summary>
        /// Associates a new listener for the specified port number and the HTTP protocol with this rule.
        /// </summary>
        /// <param name="portNumber">The port number to listen to.</param>
        /// <return>The next stage of the definition, or null if the specified port number is already used for a different protocol.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendHttpConfigOrRedirect<ParentT> FromFrontendHttpPort(int portNumber);
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to add more backend addresses,
    /// start specifying optional settings, or finish the definition by attaching it to the parent application gateway.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithBackendAddressOrAttach<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddress<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithAttach<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to add an address to the backend used by this request routing rule.
    /// A new backend will be created if none is associated with this rule yet.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithBackendAddressBeta<ParentT> :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta
    {
        /// <summary>
        /// Adds the specified IP addresses to the backend associated with this rule.
        /// </summary>
        /// <param name="ipAddresses">IP addresses to add.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithBackendAddressOrAttach<ParentT> ToBackendIPAddresses(params string[] ipAddresses);
    }

    /// <summary>
    /// The stage of an application gateway request routing rule definition allowing to associate the rule with a redirect configuration.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the application gateway update to return to after attaching this definition.</typeparam>
    public interface IWithRedirectConfigBeta<ParentT> :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta
    {
        /// <summary>
        /// Associates the specified redirect configuration with this request routing rule.
        /// </summary>
        /// <param name="name">The name of a redirect configuration on this application gateway.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayRequestRoutingRule.UpdateDefinition.IWithAttach<ParentT> WithRedirectConfiguration(string name);
    }
}